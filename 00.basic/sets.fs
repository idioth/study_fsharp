module sets

(*
Sets 만들기
- Set.empty를 사용하여 빈 set를 만들고 add 함수를 사용해 item 추가
- 시퀀스와 리스트를 set로 변환
*)

let set1 = Set.empty.Add(3).Add(5).Add(7).Add(9)
printfn "The new set: %A" set1

let weekdays = Set.ofList["mon"; "tues"; "wed"; "thurs"; "fri"]
printfn "The list set: %A" weekdays

let set2 = Set.ofSeq [1 .. 2 .. 10]
printfn "The sequence set: %A" set2

let a = Set.ofSeq [1 ..2 ..20]
let b = Set.ofSeq [1 ..3 .. 20]
let c = Set.intersect a b
let d = Set.union a b
let e = Set.difference a b

printfn "Set a: "
a |> Set.iter (fun x -> printf "%O " x)
printfn ""

printfn "Set b: "
b |> Set.iter (fun x -> printf "%O " x)
printfn ""

printfn "Set c = set intersect of a and b : "
c |> Set.iter (fun x -> printf "%O " x)
printfn ""

printfn "Set d = set union of a and b :"
d |> Set.iter (fun x -> printf "%O " x)
printfn ""

printfn "Set e = set difference of a and b : "
e |> Set.iter (fun x -> printf "%O " x)
printfn ""