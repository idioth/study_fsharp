module mutable_list

open System.Collections.Generic

let bookList = new List<string>()
bookList.Add("Gone with the Wind")
bookList.Add("Atlas Shrugged")
bookList.Add("Fountainhead")
bookList.Add("Thornbirds")
bookList.Add("Rebecca")
bookList.Add("Narnia")

printfn "Total %d books" bookList.Count
bookList |> Seq.iteri (fun index item -> printfn "%i: %s" index bookList.[index])

bookList.Insert(2, "Roots")
printfn("after inserting at Index 2")
printfn "Total %d books" bookList.Count
bookList |> Seq.iteri (fun index item -> printfn "%i: %s" index bookList.[index])

bookList.RemoveAt(3)
printfn("after removing from inex 3")
printfn "Total %d books" bookList.Count
bookList |> Seq.iteri (fun index item -> printfn "%i: %s" index bookList.[index])
