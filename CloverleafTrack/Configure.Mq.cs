using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceStack;
using ServiceStack.Messaging;
using ServiceStack.Redis;
using ServiceStack.Messaging.Redis;

[assembly: HostingStartup(typeof(CloverleafTrack.ConfigureMq))]

namespace CloverleafTrack
{
    /**
      Register Services you want available via MQ in your AppHost, e.g:
        var mqServer = container.Resolve<IMessageService>();
        mqServer.RegisterHandler<MyRequest>(ExecuteMessage);
    */
    public class ConfigureMq : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder) => builder
            .ConfigureServices((context, services) => {
                services.AddSingleton<IMessageService>(c =>
                    new RedisMqServer(c.Resolve<IRedisClientsManager>()));
            })
            .ConfigureAppHost(afterAppHostInit: appHost => {
                appHost.Resolve<IMessageService>().Start();
            });
    }
}
