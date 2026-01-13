using Web_ConferenceHallManagement.Controllers;

namespace Web_ConferenceHallManagement.Middlewares
{
    public class GlobalExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<GlobalExceptionMiddleware> _logger;
        public GlobalExceptionMiddleware(RequestDelegate next, ILogger<GlobalExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                // Log the exception (you can use any logging framework)
                //Console.WriteLine($"Global Exception Caught: {ex.Message}");
                _logger.LogError($"Global Exception Caught: {ex.Message}");

                // Optionally, you can return a custom error response
                context.Response.StatusCode = 500; // Internal Server Error
                await context.Response.WriteAsync("An unexpected error occurred.");

                //context.Response.ContentType = "application/json";
                //context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                //var errorResponse = new
                //{
                //    StatusCode = context.Response.StatusCode,
                //    Message = "An unexpected error occurred.",
                //    Detailed = ex.Message
                //};
                //await context.Response.WriteAsJsonAsync(errorResponse);
            }
        }
    }
    public static class GlobalExceptionMiddlewareExtensions
    {
        public static IApplicationBuilder UseGlobalException(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<GlobalExceptionMiddleware>();
        }
    }
}
