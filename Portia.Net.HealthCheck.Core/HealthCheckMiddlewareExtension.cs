using Microsoft.AspNetCore.Builder;

namespace Portia.Net.HealthCheck.Core
{
    public static class HealthCheckMiddlewareExtension
    {
        public static IApplicationBuilder UseHealthCheck(this IApplicationBuilder app)
        {
            app.UseMiddleware<HealthCheckMiddleware>();
            return app;
        }
    }
}
