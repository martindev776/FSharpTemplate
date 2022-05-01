module PersonsBridge

open PersonsRepository
open PersonsMapper

let GetPersonById = GetPersonById >> MapToDto