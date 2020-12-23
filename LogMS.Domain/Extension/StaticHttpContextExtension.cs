using LogMS.Domain.Helper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace LogMS.Domain.Extension
{
    public static class StaticHttpContextExtension
    {
        public static IApplicationBuilder UseStaticHttpContext(this IApplicationBuilder app)
        {
            var httpContextAccessor = app.ApplicationServices.GetRequiredService<IHttpContextAccessor>();
            HttpContextHelper.Configure(httpContextAccessor);
            return app;
        }
    }
}
