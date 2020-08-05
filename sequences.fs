module sequences

(*
seq {expr}
let seq1 = seq { 1 .. 10 }

시퀀스 생성 및 표현
- 범위 지정
- 증가 또는 감소와 함께 범위 지정
- 시퀀스의 일부과 되는 값을 yield 키워드 사용하여 생성
- -> operator 사용
*)

let seq1 = seq { 1 .. 10 }
printfn "The Sequence: %A" seq1

// 증가 범위 지정
let seq2 = seq { 1 .. 5 .. 50 }
printfn "The Sequence: %A" seq2

// 감소 범위 지정
let seq3 = seq { 50 .. -5 .. 0 }
printfn "The Sequence: %A" seq3

// using yield
let seq4 = seq { for a in 1 .. 10 do yield a, a * a, a * a * a}
printfn "The Sequence: %A" seq4

// recursive isprime function
let isprime n =
    let rec check i =
        i > n/2 || (n % i <> 0 && check(i+1))
    check 2

let primeln50 = seq { for n in 1 .. 50 do if isprime n then yield n }
for x in primeln50 do
    printfn "%d" x

// 시퀀스 생성
let emptySeq = Seq.empty
let _seq1 = Seq.singleton 20

printfn "The singleton sequence: "
printfn "%A " _seq1
printfn "The init sequence: "

let _seq2 = Seq.init 5 (fun n -> n * 3)
Seq.iter (fun i -> printf "%d " i) _seq2
printfn ""

// cast 사용에 의한 array -> sequence 변환
printfn "The array sequence 1:"
let _seq3 = [| 1 .. 10 |] :> seq<int>
Seq.iter (fun i -> printf "%d " i) _seq3
printfn ""

// Seq.ofArray 사용에 의한 array -> sequence 변환
printfn "The array sequence 2:"
let _seq4 = [| 2 .. 2 .. 20 |] |> Seq.ofArray
Seq.iter (fun i -> printf "%d " i) _seq4
printfn ""

(*
Seq.empty : 빈 시퀀스를 생성
Seq.singleton : 하나의 원소를 가진 시퀀스를 생성
Seq.init : 주어진 함수 사용에 의해 생성된 요소들의 시퀀스 생성
Seq.ofArray, ofList<'T> : 배열/리스트로부터 시퀀스 생성
Seq.iter : 시퀀스 반복
*)

let sq1 = 0 |> Seq.unfold (fun state -> if (state > 20) then None else Some(state, state + 1))
printfn "The sequence sq1 contains numbers from 0 to 20"
for x in sq1 do printf "%d " x
printfn " "

let mySeq = seq { for i in 1 .. 10 -> 3*i}
let truncatedSeq = Seq.truncate 5 mySeq
let takeSeq = Seq.take 5 mySeq

printfn "The original sequence"
Seq.iter (fun i -> printf "%d " i) mySeq
printfn ""

printfn "The truncated sequence"
Seq.iter (fun i -> printf "%d " i) truncatedSeq
printfn ""

printfn "The take sequence"
Seq.iter (fun i -> printf "%d " i) takeSeq
printfn ""