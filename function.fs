module _function

open System

// let [inline] function-name parameter-list [ : return - type] = function-body
let cylinderVolume radius length : float =
    let pi = 3.14159
    length * pi * radius * radius

let vol = cylinderVolume 3.0 5.0
printfn "Volume: %g" vol

let max num1 num2 : int32 =
    if(num1 > num2) then
        num1
    else
        num2

let res = max 39 52
printfn "Max Value: %d" res

let doublelt (x : int) = 2 * x
printfn "Double 19: %d" (doublelt(19))

// Recursive Functions
// let rec function-name parameter-list = recursive-function body
let rec fib n = if n < 2 then 1 else fib(n-1) + fib(n-2)
for i = 1 to 10 do
    printfn "Fibonacci %d: %d" i (fib i)

let rec fact x =
    if x < 1 then 1
    else x * fact(x-1)
Console.WriteLine(fact 8)

// Lambda Expressions
let applyFunction (f:int -> int -> int) x y = f x y
let res2 = applyFunction (fun x y -> x * y) 5 7
printfn "%d" res2

// Function Composition and Pipelining
let function1 x = x + 1
let function2 x = x * 5

let f = function1 >> function2  // Composition
let res3 = f 10
printfn "%d" res3

let res4 = 10 |> function1 |> function2    // Pipelining
printfn "%d" res4