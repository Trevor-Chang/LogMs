using Microsoft.AspNetCore.Builder;

public static class ConfigurationExtension
{
    public static IApplicationBuilder UseStaticConfiguration(this IApplicationBuilder app, Microsoft.Extensions.Configuration.IConfiguration configuration)
    {
        ConfigHelper.Configure(configuration);

        return app;
    }
}
