using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace TariffComparison.Data.Middlewares
{
    public class RequestResponseMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestResponseMiddleware> _logger;

        public RequestResponseMiddleware(RequestDelegate next, ILogger<RequestResponseMiddleware> logger)
        {
                _next = next;
                _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            // need to keep response body to avoid get overriden
            var originalBodyStream = context.Response.Body;

            var tempStream = new MemoryStream();

            context.Response.Body = tempStream;

            await _next.Invoke(context);

            context.Response.Body.Seek(0, SeekOrigin.Begin);
            var responseText = await new StreamReader(context.Response.Body, Encoding.UTF8).ReadToEndAsync();
            context.Response.Body.Seek(0, SeekOrigin.Begin);

            // log the response object
            _logger.LogInformation($"LoggingMiddleware --> The response object is: {responseText}");

            // refill the body
            await context.Response.Body.CopyToAsync(originalBodyStream);
        }
    }
}
