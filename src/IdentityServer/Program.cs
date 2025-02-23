var builder = WebApplication.CreateBuilder(args);

builder.Services.AddIdentityServer();

var app = builder.Build();

app.UseIdentityServer();

app.Run();
