namespace CustomMiddleware.Middlewares
{
    public class Middleware1
    {
        private readonly RequestDelegate _next;

        public Middleware1(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            context.TraceIdentifier = "a";

            await _next(context);

            context.TraceIdentifier = context.TraceIdentifier + "1";

            context.Response.Headers.Add("X-Trace-Id", context.TraceIdentifier);
        }
    }
}
