namespace FSharpIntro

module Program = 

    [<EntryPoint>]
    let main argv = 

        let bigNumber = RobMath.makeBigger 20

        printfn "%A" bigNumber

        let addedNumber = RobMath.add 15 23

        printfn "%A" addedNumber

        let addedString = RobText.stringConcat "Hello, " "Rob!"

        printfn "%A" addedString

        let lastStringParam = RobText.getLastParam "Hello, " "Rob!"

        printfn "%A" lastStringParam

        let lastNumParam = RobText.getLastParam 2 3

        printfn "%A" lastNumParam

        let p1 = {
            name = "Rob"
            age = 21
        }

        let p2 = {
            name = "Darren"
            age = 99
        }

        let p3 = {
            name = "Rob"
            age = 21
        }

        let p1equalsP2 = PersonThings.comparePeople p1 p2

        let p1equalsP3 = PersonThings.comparePeople p1 p3

        printfn "%A" p1equalsP2

        printfn "%A" p1equalsP3

        ignore(System.Console.ReadKey())

        0 // return an integer exit code
