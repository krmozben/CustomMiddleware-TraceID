namespace CustomMiddleware.Middlewares
{
    public class Middleware3
    {
        private readonly RequestDelegate _next;

        public Middleware3(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            context.TraceIdentifier = context.TraceIdentifier + "c";

            await _next(context);

            context.TraceIdentifier = context.TraceIdentifier + "3";
        }
    }
}
