using ServiceStack;

[assembly: HostingStartup(typeof(CloverleafTrack.ConfigureServerEvents))]

namespace CloverleafTrack
{
    public class ConfigureServerEvents : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder) => builder
            .ConfigureAppHost(appHost => {
                appHost.Plugins.Add(new ServerEventsFeature());
            });
    }
}