module string

// Ignoring the escape sequence
// Using @ symbol
// Enclosing the string in triple quotes
let xmldata = @"<book author = ""Lewis, C.S"" title = ""Narnia"">"
printfn "%s" xmldata

let collectTesting inputS =
    String.collect (fun c -> sprintf "%c " c) inputS
printfn "%s" (collectTesting "Happy New Year!")

let strings = [ "Tutorials Point"; "Coding Ground"; "Absolute Classes"]
let ourProducts = String.concat "\n" strings
printfn "%s" ourProducts

printfn "%s" <| String.replicate 10 "+! "