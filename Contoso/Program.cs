using Contoso;
using Contoso.Services;
using Contoso.Services.Logic;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Net.Http.Headers;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var httpClient = new HttpClient()
{
    BaseAddress = new Uri($"https://localhost:{builder.Configuration["port"]}/api/")
};

httpClient.DefaultRequestHeaders.Accept.Clear();
httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

builder.Services.AddScoped(sp => httpClient);
builder.Services.AddTransient<IAuthService, AuthService>();

await builder.Build().RunAsync();
