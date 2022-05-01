module PersonsComposer

open PersonsService
open PersonsBridge

let GetPersonWithAgeById id =
    id
    |> GetPersonWithAgeById GetPersonById