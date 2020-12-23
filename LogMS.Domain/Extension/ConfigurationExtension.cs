using LogMS.Domain.Helper;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogMS.Domain.Extension
{
    public static class ConfigurationExtension
    {
        public static IApplicationBuilder UseStaticConfiguration(this IApplicationBuilder app, Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            ConfigHelper.Configure(configuration);

            return app;
        }
    }
}
