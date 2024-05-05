using Blazored.LocalStorage;
using ClientProject;
using Mapster;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Radzen;
using SchoolProjectClient.Client.Model.Login;
using SchoolProjectClient.Client.Model.Utils;
using SchoolProjectClient.Client.Services;
using SchoolProjectClient.Client.Services.Baskets;
using SchoolProjectClient.Client.Services.Comments;
using SchoolProjectClient.Client.Services.Login;
using SchoolProjectClient.Client.Services.Posts;
using SchoolProjectClient.Client.Services.PublicProfile;
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
builder.Services.AddScoped<IPublicProfileService, PublicProfileService>();
builder.Services.AddScoped<AuthenticationStateProvider, AuthStateProvider>();
builder.Services.AddMudServices();
builder.Services.AddMapster();

builder.Services.AddAuthorizationCore();

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddRadzenComponents();
builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<ContextMenuService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<TooltipService>();


builder.Services.AddScoped<AppUserId>();


await builder.Build().RunAsync();
