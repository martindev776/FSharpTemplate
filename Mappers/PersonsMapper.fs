module PersonsMapper

let MapToDto (person: PersonsRepository.Person) =
    { Id = person.Id
      FirstName = person.FirstName
      LastName = person.LastName
      DateOfBirth = person.DateOfBirth } : PersonsService.PersonDto