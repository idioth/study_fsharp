module lists

(*
리스트를 만드는 다양한 방법
- list literals 사용
- cons (::) operator 사용
- List 모듈의 List.init 메소드 사용
- List Comprehensions라 불리는 syntactic constructs 사용
*)

// list literals
let list1 = [1; 2; 3; 4; 5; 6; 7; 8; 9; 10]
printfn "The list: %A" list1

// cons operator
let list2 = 1 :: 2 :: 3 :: []
printfn "The list: %A" list2

// range constructs
let list3 = [1 .. 10]
let list4 = ['a' .. 'm']
printfn "The list: %A" list3
printfn "The list: %A" list4

// init method
let list5 = List.init 5 (fun index -> (index, index * index, index * index * index))
printfn "The list: %A" list5

// yield operator
let list6 = [for a in 1 .. 10 do yield (a * a)]
let list7 = [for a in 1 .. 100 do if a % 3 = 0 && a % 5 = 0 then yield a]
let list8 = [for a in 1 .. 3 do yield! [a .. a+3]]
printfn "The list: %A" list6
printfn "The list: %A" list7
printfn "The list: %A" list8

let list = [2; 4; 6; 8; 10; 12; 14; 16]

printfn "list.IsEmpty is %b" (list.IsEmpty)
printfn "list.Length is %d" (list.Length)
printfn "list.Head is %d" (list.Head)
printfn "list.Tail.Head is %d" (list.Tail.Head)
printfn "list.Tail.Tail.Head is %d" (list.Tail.Tail.Head)
printfn "list.Item(1) is %d" (list.Item(1))

printfn "The original list: %A" list

let reverse lt =
    let rec loop acc = function
        | [] -> acc
        | hd :: tl -> loop (hd :: acc) tl
    loop [] lt

printfn "The reversed list: %A" (reverse list)
printfn "The reversed list: %A" (List.rev list)

printfn "The list: %A" list1
let list_fil = list1 |> List.filter (fun x -> x % 2 = 0)
printfn "The Filtered list: %A" list_fil

let list_map = list1 |> List.map (fun x -> (x * x).ToString());;
printfn "The Mapped list: %A" list_map

let lt1 = [1; 2; 3; 4; 5]
let lt2 = [6; 7; 8; 9; 10]
let lt3 = List.append lt1 lt2

printfn "The first list: %A" lt1
printfn "The second list: %A" lt2
printfn "The appended list: %A" lt3

let lst1 = ['a'; 'b'; 'c']
let lst2 = ['e'; 'f'; 'g']
let lst3 = lst1 @ lst2

printfn "The first list: %A" lst1
printfn "The second list: %A" lst2
printfn "The appended list: %A" lst3

let _list1 = [9.0; 0.0; 2.0; -4.5; 11.2; 8.0; -10.0]
printfn "The list: %A" _list1

let _list2 = List.sort _list1
printfn "The sorted list: %A" _list2

let s = List.sum _list1
let avg = List.average _list1
printfn "The sum: %f" s
printfn "The average: %f" avg

let sumList list = List.fold (fun acc elem -> acc + elem) 0 list
printfn "Sum of the elements of list %A is %d." [1 .. 10] (sumList([1..10]))