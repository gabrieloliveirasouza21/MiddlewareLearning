var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


//1° chamada
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    //lógica
    await next(context);
});

//2° chamada
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    //logica
    await next(context);
});

//3° chamada
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Hello");
});

app.Run();
