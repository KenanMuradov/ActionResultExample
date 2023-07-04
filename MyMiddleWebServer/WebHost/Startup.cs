using ActionResultExample.Middlewares;
using ActionResultExample.WebHost;

namespace ActionResultExample.WebHost;
public class Startup : IStartup
{
    public void Configure(MiddlewareBuilder builder)
    {
        builder.Use<LoggerMiddleware>();
        builder.Use<StaticFileMiddleware>();
        builder.Use<MvcMiddleware>();
    }
}
