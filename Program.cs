var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello, I am Rupalee. I am learning DevOps!");

app.Run();
