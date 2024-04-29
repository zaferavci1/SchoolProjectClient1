using System.Net.NetworkInformation;
using System.Reflection;
using Mapster;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using SchoolProjectClient.Client;
using SchoolProjectClient.Client.Model.Login;
using SchoolProjectClient.Client.Services;
using SchoolProjectClient.Client.Services.Baskets;
using SchoolProjectClient.Client.Services.Comments;
using SchoolProjectClient.Client.Services.Login;
using SchoolProjectClient.Client.Services.Posts;
using SchoolProjectClient.Client.Services.Users;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IBasketService, BasketService>();
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<IHttpClientService, HttpClientService>();
builder.Services.AddMudServices();

builder.Services.AddMapster();

builder.Services.AddSingleton<AppUserId>();
builder.Services.AddScoped<AppUserId>();


await builder.Build().RunAsync();

