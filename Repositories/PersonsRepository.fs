module PersonsRepository

open System


type Person = {
    Id: int
    FirstName: string
    LastName: string
    DateOfBirth: DateTime
}

//Simulating a database table
let GetPersons() =
    [|
      {Id = 1
       FirstName = "John"
       LastName = "Smith"
       DateOfBirth = Convert.ToDateTime("1905-01-01")};
      {Id = 2
       FirstName = "Jane"
       LastName = "Doe"
       DateOfBirth = Convert.ToDateTime("1907-02-01")};
      {Id = 3
       FirstName = "John"
       LastName = "Smith"
       DateOfBirth = Convert.ToDateTime("1985-03-01")};
      {Id = 4
       FirstName = "Jane"
       LastName = "Doe"
       DateOfBirth = Convert.ToDateTime("1987-04-01")}
    |]

let GetPersonById id =
    let person = () |> GetPersons |> Array.filter (fun x -> x.Id = id) |> Array.head

    match box person with
    | null -> raise (new Exception($"Can't find person with Id: {id}"))
    | _ -> person