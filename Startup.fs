namespace DotnetCoreAzureDeployment

open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Configuration
open Microsoft.Extensions.DependencyInjection

type Startup() =
    member this.ConfigureServices(services: IServiceCollection) =
        services.Configure<CookiePolicyOptions>(fun (options: CookiePolicyOptions) ->
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded <- fun context -> true
                options.MinimumSameSitePolicy <- SameSiteMode.None
            )
           .AddMvc()
           .SetCompatibilityVersion(CompatibilityVersion.Version_2_2) |> ignore

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    member this.Configure(app: IApplicationBuilder, env: IHostingEnvironment)  =
        if (env.IsDevelopment()) then
            app.UseDeveloperExceptionPage() |> ignore
        else
            app.UseExceptionHandler("/Error")
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
               .UseHsts() |> ignore

        app.UseHttpsRedirection() 
           .UseStaticFiles()
           .UseCookiePolicy()
           .UseMvc() |> ignore
