using ActionResultExample.Middlewares;

namespace ActionResultExample.WebHost
{
    public interface IStartup
    {
        public void Configure(MiddlewareBuilder builder);
    }
}
