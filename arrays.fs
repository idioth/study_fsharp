module arrays

(*
배열 생성
- [| |] 사이에 값을 적고 ; 로 구분
- 각각의 원소를 다른 줄에 넣음, ;은 선택사항
- sequence 표현 사용
*)

// using semicolon separator
let array1 = [| 1; 2; 3; 4; 5; 6 |]

// without semicolon separator
let array2 =
    [|
        1
        2
        3
        4
        5
    |]

// using sequence
let array3 = [| for i in 1 .. 10 -> i * i |]

for i in 0 .. array1.Length - 1 do
    printf "%d " array1.[i]
printfn " "
    
for i in 0 .. array2.Length - 1 do
    printf "%d " array2.[i]
printfn " "

for i in 0 .. array3.Length - 1 do
    printf "%d " array3.[i]
printfn " "

// using create and set
let arr1 = Array.create 10 ""
for i in 0 .. arr1.Length - 1 do
    Array.set arr1 i (i.ToString())
for i in 0 .. arr1.Length - 1 do
    printf "%s " (Array.get arr1 i)
printfn " "

// empty array
let arr2 =  Array.empty
printfn "Length of empty array: %d" arr2.Length

let arr3 = Array.create 10 7.0
printfn "Float Array: %A" arr3

// using the init and zeroCreate
let arr4 = Array.init 10 (fun index -> index * index)
printfn "Array of squares: %A" arr4

let arr5 : float array = Array.zeroCreate 10
let (myZeroArray : float array) = Array.zeroCreate 10
printfn "Float Array: %A" arr5

let _arr1 = [| 0 .. 50 |]
let _arr2 = Array.sub _arr1 5 15
printfn "Sub Array:"
printfn "%A" _arr2

let _arr3 = [| 1; 2; 3; 4 |]
let _arr4 = [| 5 .. 9 |]
printfn "Appended Array:"
let _arr5 = Array.append _arr3 _arr4
printfn "%A" _arr5

let _arr6 = [| 1 .. 20 |]
let _arr7 = Array.choose (fun elem -> if elem % 3 = 0 then Some(float (elem)) else None) _arr6

printfn "Array with Chosen elements:"
printfn "%A" _arr7

let _arr8 = [| 2 .. 5 |]
let _arr9 = Array.collect (fun elem -> [| 0 .. elem - 1 |]) _arr8
printfn "Array with collected elements:"
printfn "%A" _arr9