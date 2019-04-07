namespace DotnetCoreAzureDeployment.Pages

open Microsoft.AspNetCore.Mvc.RazorPages

type IndexModel () =
    inherit PageModel()

    member this.OnGet() =
        ()