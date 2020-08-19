module shopping_cart

type CartItem = string

type EmptyState = NoItems
type ActiveState = { UnpaidItems : CartItem list; }  
type PaidForState = { PaidItems : CartItem list; Payment: decimal}

type Cart =
    | Empty of EmptyState
    | Active of ActiveState
    | PaidFor of PaidForState

let addToEmptyState item =
    Cart.Active { UnpaidItems=[item] }

let addToActiveState state itemToAdd =
    let newList = itemToAdd :: state.UnpaidItems
    Cart.Active { state with UnpaidItems = newList}

let removeFromActiveState state itemToRemove =
    let newList = state.UnpaidItems |> List.filter (fun i -> i<>itemToRemove)

    match newList with
    | [] -> Cart.Empty NoItems
    | _ -> Cart.Active { state with UnpaidItems = newList}

let payForActiveState state amount =
    Cart.PaidFor { PaidItems=state.UnpaidItems; Payment=amount }

type EmptyState with
    member this.Add = addToEmptyState

type ActiveState with
    member this.Add = addToActiveState this
    member this.Remove = removeFromActiveState this
    member this.Pay = payForActiveState this

let addItemToCart cart item =
    match cart with
    | Empty state -> state.Add item
    | Active state -> state.Add item
    | PaidFor state ->
        printfn "ERROR: The cart is paid for"
        cart

let removeItemFromCart cart item =
    match cart with
    | Empty state ->
        printfn "ERROR: The cart is empty"
        cart
    | Active state ->
        state.Remove item
    | PaidFor state ->
        printfn "ERROR: The cart is paid for"
        cart

let displayCart cart =
    match cart with
    | Empty state ->
        printfn "The cart is empty"
    | Active state ->
        printfn "The cart contains %A unpaid items" state.UnpaidItems
    | PaidFor state ->
        printfn "The cart contains %A paid items. Amount paid: %f" state.PaidItems state.Payment

let CartPaid cart amount =
    match cart with
    | Empty _ | PaidFor _ -> cart
    | Active state -> state.Pay amount

type Cart with
    static member NewCart = Cart.Empty NoItems
    member this.Add = addItemToCart this
    member this.Remove = removeItemFromCart this
    member this.Display = displayCart this

let cart1 = Cart.NewCart
printf "cart1 = "; cart1.Display

let cart2 = cart1.Add "A"
printf "cart2 = "; cart2.Display

let cart3 = cart2.Add "B"
printf "cart3 = "; cart3.Display

let cart2Paid = CartPaid cart2 100m
printf "cart2Paid = "; cart2Paid.Display

let cart1Paid = CartPaid cart1 100m
printf "empty cart1Paid = "; cart1Paid.Display