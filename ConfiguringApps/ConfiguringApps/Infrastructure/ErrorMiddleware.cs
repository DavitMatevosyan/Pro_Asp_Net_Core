using Microsoft.AspNetCore.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConfiguringApps.Infrastructure
{
    public class ErrorMiddleware
    {
        private RequestDelegate nextDelegate;

        public ErrorMiddleware(RequestDelegate next)
        {
            nextDelegate = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext.Response.StatusCode == 403)
            {
                await httpContext.Response.WriteAsync("Edge is not supported", Encoding.UTF8);

            }
            else
            {
                await httpContext.Response.WriteAsync("No content middleware response", Encoding.UTF8);
            }

        }
    }
}
