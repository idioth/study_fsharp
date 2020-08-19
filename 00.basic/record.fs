module record

// record는 tuple과 비슷하지만, 이름을 가진 필드를 포함함
// tpye recordName = { [ fieldName : dataType ] + }

// defining a record type named website
type website =
    { Title : string;
        Url : string }

// creating some records
let homepage = { Title = "TutorialsPoint"; Url ="www.tutorialspoint.com" }
let cpage = { Title = "Learn C"; Url = "www.tutorialspoint.com/cprogramming/index.htm" }
let fsharppage = { Title = "Learn F#"; Url = "www.tutorialspoint.com/fsharp/index.htm" }
let csharppage = { Title = "Learn C#"; Url = "www.tutorialspoint.com/csharp/index.htm" }

// printing records
(printfn "Home Page: Title: %A \n \t URL: %A") homepage.Title homepage.Url
(printfn "C Page: Title: %A \n \t URL: %A") cpage.Title cpage.Url
(printfn "F# Page: Title: %A \n \t URL: %A") fsharppage.Title fsharppage.Url
(printfn "C# Page: TItle: %A \n \t URL: %A") csharppage.Title csharppage.Url

type student =
    { Name : string;
        ID : int;
        RegistrationText : string;
        IsRegistered : bool }

let getStudent name id =
    { Name = name; ID = id; RegistrationText = null; IsRegistered = false }

let registerStudent st =
    { st with
        RegistrationText = "Registered";
        IsRegistered = true }

let printStudent msg st =
    printfn "%s: %A" msg st

let main() = 
    let preRegisteredStudent = getStudent "Zara" 10
    let postRegisteredStudent = registerStudent preRegisteredStudent

    printStudent "Befor Registration: " preRegisteredStudent
    printStudent "After Registration: " postRegisteredStudent

main()