module mutable_data

open System

(*
F#의 변수는 변경할 수 없으므로 변수에 값이 바운딩되면 변경할 수 없음
컴파일 시 static read-only 속성으로 컴파일됨
F#에서는 mutable keyword를 통해 값을 변경할 변수를 선언하고 할당할 수 있음
*)

let mutable x = 10
let y = 20
let mutable z = x + y

printfn "Original Values:"
printfn "x: %i" x
printfn "y: %i" y
printfn "z: %i" z

printfn "Let us change the value of x"
printfn "Value of z will change too."

x <- 15
z <- x + y

printfn "New Values:"
printfn "x: %i" x
printfn "y: %i" y
printfn "z: %i" z

type studentData =
    { ID : int;
        mutable IsRegistered : bool;
        mutable RegisteredText : string; }

let getStudent id =
    { ID = id;
        IsRegistered = false;
        RegisteredText = null; }

let registerStudents (students : studentData list) =
    students |> List.iter(fun st ->
        st.IsRegistered <- true
        st.RegisteredText <- sprintf "Registered %s" (DateTime.Now.ToString("hh:mm:ss"))
        Threading.Thread.Sleep(1000))

let printData (students : studentData list) =
    students |> List.iter (fun x -> printfn "%A" x)

let main() =
    let students = List.init 3 getStudent

    printfn "Before Process:"
    printData students

    printfn "After Process:"
    registerStudents students
    printData students

    Console.ReadKey(true) |> ignore

main()