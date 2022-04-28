using BlazorPCGTools;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();

/* TODO:
    -- MENU: https://code-maze.com/creating-blazor-material-navigation-menu/
    -- Splash Screen: https://darthpedro.net/2021/03/17/how-to-create-blazor-app-splash-screen/
    -- (routing): https://docs.microsoft.com/en-us/aspnet/core/blazor/fundamentals/routing?view=aspnetcore-6.0
 */

