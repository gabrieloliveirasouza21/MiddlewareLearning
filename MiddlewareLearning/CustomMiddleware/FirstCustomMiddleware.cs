
namespace MiddlewareLearning.CustomMiddleware
{
    public class FirstCustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("middleware customizado começa aqui");
            await next(context);
            await context.Response.WriteAsync("Esse aqui esta sendo retornado depois de chamar o segundo middleware");
        }
    }
}
