using Contoso;
using Contoso.Service;
using Contoso.Service.Logic;
using IgniteUI.Blazor.Controls;
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
builder.Services.AddScoped(typeof(IIgniteUIBlazor), typeof(IgniteUIBlazor));

builder.Services.AddTransient<IAuthService, AuthService>();
builder.Services.AddTransient<IProductionService, ProductionService>();
builder.Services.AddTransient<IClientsService, ClientsService>();
builder.Services.AddTransient<IOrdersService, OrdersService>();
builder.Services.AddTransient<IPricesService, PricesService>();

await builder.Build().RunAsync();
