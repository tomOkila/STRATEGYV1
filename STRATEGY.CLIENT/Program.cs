using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;
using STRATEGY.CLIENT;
using STRATEGY.CLIENT.Services;
using STRATEGY.CLIENT.States;
using STRATEGY.WEBAPI.Helpers;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7271/") });
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IStrategyService, StrategyService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<HttpClientValidator>();
builder.Services.AddSingleton<MyStateContainer>();
builder.Services.AddAuthorizationCore();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddRadzenComponents();

await builder.Build().RunAsync();
