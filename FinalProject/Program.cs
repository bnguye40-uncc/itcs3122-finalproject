using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazor.BrowserExtension;
using Blazored.LocalStorage;
using FinalProject;
using FinalProject.Shared;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.UseBrowserExtension(browserExtension =>
{
    builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

    builder.Services.AddBlazoredLocalStorage();

    builder.Services.AddSingleton<StateContainer>();
    
    if (browserExtension.Mode == BrowserExtensionMode.Background)
    {
        builder.RootComponents.AddBackgroundWorker<BackgroundWorker>();
    }
    else
    {
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");
    }
});

await builder.Build().RunAsync();
