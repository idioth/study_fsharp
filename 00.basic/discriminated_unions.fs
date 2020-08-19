module discriminated_unions

(*
type type-name =
    | case-identifier1 [of [ fieldname1 : ] type1 [ * [ fieldname2 : ] type2...]
    | case-identifier2 [of [ fieldname3 : ] type3 [ * [ fieldname4 : ] type4...]
*)

type VoltageState =
    | High
    | Low

let toggleSwitch = function
    | High -> Low
    | Low -> High

let main() =
    let on = High
    let off = Low
    let change = toggleSwitch off

    printfn "Switch on state: %A" on
    printfn "Switch off state: %A" off
    printfn "Toggle off: %A" change
    printfn "Toggle the Changed stat: %A" (toggleSwitch change)

main()

type Shape =
    | Circle of float // store the radius of a circle
    | Square of float // store the side length
    | Rectangle of float * float // store the height and width

let pi = 3.141592654

let area myShape =
    match myShape with
    | Circle radius -> pi * radius * radius
    | Square s -> s * s
    | Rectangle (h, w) -> h * w

let radius = 12.0
let myCircle = Circle(radius)
printfn "Area of circle with radius %g: %g" radius (area myCircle)

let side = 15.0
let mySquare = Square(side)
printfn "Area of square that has side %g: %g" side (area mySquare)

let height, width = 5.0, 8.0
let myRectangle = Rectangle(height, width)
printfn "Area of rectangle with height %g and width %g is %g" height width (area myRectangle)