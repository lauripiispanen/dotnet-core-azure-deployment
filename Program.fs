namespace DotnetCoreAzureDeployment

open Microsoft.AspNetCore
open Microsoft.AspNetCore.Hosting

module Program =
    [<EntryPoint>]
    let main argv =
        WebHost.CreateDefaultBuilder(argv)
                .UseStartup<Startup>()
                .Build()
                .Run()
        0