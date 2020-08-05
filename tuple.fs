module tuple

let averageFour (a, b, c, d) =
    let sum = a + b + c + d
    sum / 4.0

let avg:float = averageFour(4.0, 5.1, 8.0, 12.0)
printfn "Avg of four numbers: %f" avg

let display tuple1 =
    match tuple1 with
    | (a, b, c) -> printfn "Detila Info: %A %A %A" a b c

display("Zara Ali", "Hyderabad", 10)

printfn "First member: %A" (fst(23, 30))
printfn "Second member: %A" (snd(23, 30))

printfn "First member: %A" (fst("Hello", "World"))
printfn "Second member: %A" (snd("Hello", "World"))

let nameTuple = ("Zara", "Ali")

printfn "First Name: %A" (fst nameTuple)
printfn "Second Name: %A" (snd nameTuple)