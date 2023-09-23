using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Social;
using Social.Services.Comments;
using Social.Services.Posts;
using Social.Services.Users;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IUserInterface, UsersService>();
builder.Services.AddScoped<IPostInterface, PostService>();
builder.Services.AddScoped<ICommentsInterface, CommentsService>();


await builder.Build().RunAsync();
