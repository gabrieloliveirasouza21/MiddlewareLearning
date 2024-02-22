using MiddlewareLearning.CustomMiddleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<FirstCustomMiddleware>();
var app = builder.Build();

//app.UseMiddleware<FirstCustomMiddleware>();
app.UseCustomMiddleware();


app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Chamada do meio");
    await next(context);
});

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Hello");
});

app.Run();
