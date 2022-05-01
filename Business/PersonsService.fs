module PersonsService

open System

type PersonWithAgeDto = {
    Name: string
    Age: int
}

type PersonDto = {
    Id: int
    FirstName: string
    LastName: string
    DateOfBirth: DateTime
}

let CalculateAge (dateOfBirth: DateTime) =
    let now = DateTime.Today
    let age = now.Year - dateOfBirth.Year
    if dateOfBirth > now.AddYears(-age) then age - 1 else age

let GetPersonWithAgeById getPersonById id =
    let personDto = id |> getPersonById

    { Name = $"{personDto.LastName}, {personDto.FirstName}"
      Age = personDto.DateOfBirth |> CalculateAge }

