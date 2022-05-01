namespace FSharpTemplate.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging
open PersonsComposer 

[<ApiController>]
[<Route("[controller]")>]
type PersonsController (logger : ILogger<PersonsController>) =
    inherit ControllerBase()

    [<HttpGet>]
    member _.Index() =
        "This is persons controller"

    [<HttpGet; Route("GetPersonWithAge/{id}")>]
    member _.GetPersonWithAge(id: int) =
        id |> GetPersonWithAgeById