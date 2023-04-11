using ServiceStack;

[assembly: HostingStartup(typeof(CloverleafTrack.ConfigureCors))]

namespace CloverleafTrack
{
    public class ConfigureCors : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder) => builder
            .ConfigureAppHost(appHost => {
                appHost.Plugins.Add(new CorsFeature());
            });
    }
}