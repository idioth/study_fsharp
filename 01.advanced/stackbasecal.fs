module stackbasecal

type Stack = StackContents of float list

let push x (StackContents contents) =
    StackContents (x::contents)

let pop (StackContents contents) =
    match contents with
    | top::rest ->
        let newStack = StackContents rest
        (top, newStack)
    | [] -> failwith "Stack underflow"

let binary mathFn stack =
    let y, stack' = pop stack
    let x, stack'' = pop stack'
    let z = mathFn x y
    push z stack''

let unary f stack =
    let x, stack' = pop stack
    push (f x) stack'

let SHOW stack =
    let x, _ = pop stack
    printfn "The answer is %f" x
    stack

let DUP stack =
    let x, _ = pop stack
    push x stack

let SWAP stack =
    let x, s = pop stack
    let y, s' = pop s
    push y (push x s')

let DROP stack =
    let _, s = pop stack
    s

let EMPTY = StackContents []
let START = EMPTY

let ONE = push 1.0
let TWO = push 2.0
let THREE = push 3.0
let FOUR = push 4.0
let FIVE = push 5.0

let ADD = binary (+)
let SUB = binary (-)
let MUL = binary (*)
let DIV = binary (/)

let SQUARE =
    DUP >> MUL

let CUBE =
    DUP >> DUP >> MUL >> MUL

START |> THREE |> SQUARE |> SHOW |> ignore