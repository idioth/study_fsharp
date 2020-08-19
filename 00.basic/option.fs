module option

let div x y =
    match y with
    | 0 -> None
    | _ -> Some(x/y)

let res : int option = div 20 4
printfn "Result: %A" res

let checkPositive (a : int) =
    if a > 0 then
        Some(a)
    else None

let res2 : int option = checkPositive(-31)
printfn "Result: %A" res2

printfn "Result: %A" res
printfn "Result: %A" res.Value

let isHundred = function
    | Some(100) -> true
    | Some(_) | None -> false

printfn "%A" (isHundred(Some(45)))
printfn "%A" (isHundred(Some(100)))
printfn "%A" (isHundred None)