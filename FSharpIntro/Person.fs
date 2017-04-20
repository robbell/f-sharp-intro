namespace FSharpIntro

type Person = {
    name: string
    age: int
}

module PersonThings = 

    let comparePeople person1 person2 =
        person1 = person2