module maps

(*
Map.empty로 빈 map을 생성한 후 Add 함수를 통해 item을 추가하여 생성
*)

// Create an empty Map
let students =
    Map.empty.
        Add("Zara Ali", "1501").
        Add("Rishita Gupta", "1502").
        Add("Robin Sahoo", "1503").
        Add("Gillian Megan", "1504").
        Add("Shraddha Dubey", "1505").
        Add("Novonil Sarker", "1506").
        Add("Joan Paul", "1507");;
printfn "Map - students: %A" students
printfn "Map - number of students: %d" students.Count

let found = students.TryFind "Rishita Gupta"
match found with
| Some x -> printfn "Found %s." x
| None -> printfn "Did not find the specified value."

// key를 통해 element에 접근
printfn "%A" students.["Zara Ali"]

// list를 map을 변환
let capitals =
    [ "Argentina", "Buenos Aires";
        "France ", "Paris";
        "Chili", "Santiago";
        "Malaysia", "Kuala Lumpur";
        "Switzerland", "Bern" ]
    |> Map.ofList;;
printfn "Map capitals: %A" capitals