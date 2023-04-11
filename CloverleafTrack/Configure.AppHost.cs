using Funq;
using ServiceStack;
using CloverleafTrack.ServiceInterface;

[assembly: HostingStartup(typeof(CloverleafTrack.AppHost))]

namespace CloverleafTrack;

public class AppHost : AppHostBase, IHostingStartup
{
    public void Configure(IWebHostBuilder builder) => builder
        .ConfigureServices(services => {
            // Configure ASP.NET Core IOC Dependencies
        });

    public AppHost() : base("CloverleafTrack", typeof(MyServices).Assembly) {}

    public override void Configure(Container container)
    {
        SetConfig(new HostConfig {
        });
    }
}
