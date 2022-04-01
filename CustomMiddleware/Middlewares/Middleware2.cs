namespace CustomMiddleware.Middlewares
{
    public class Middleware2
    {
        private readonly RequestDelegate _next;

        public Middleware2(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            context.TraceIdentifier = context.TraceIdentifier + "b";

            await _next(context);

            context.TraceIdentifier = context.TraceIdentifier + "2";
        }
    }
}
