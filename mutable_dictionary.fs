module mutable_dictionary

open System.Collections.Generic

let dict = new Dictionary<string, string>()

dict.Add("1501", "Zara Ali")
dict.Add("1502", "Rishita Gupta")
dict.Add("1503", "Robin Sahoo")
dict.Add("1504", "Gillian Megan")

printfn "Dictionary - strudents: %A" dict
printfn "Total Number of Students: %d" dict.Count
printfn "The keys: %A" dict.Keys
printfn "The Values: %A" dict.Values