using Microsoft.Extensions.DependencyInjection;

namespace MasterDevs.ChromeDevTools
{
    public static class IServiceCollectionExtensions
    {
        public static void AddChromeDevTools(this IServiceCollection self)
        {
            self.AddSingleton<IChromeSessionFactory, RemoteChromeSessionFactory>();
            self.AddSingleton<IChromeProcessFactory, RemoteChromeProcessFactory>(
                x => new RemoteChromeProcessFactory(
                    x.GetRequiredService<IChromeSessionFactory>()
                )
            );
        }
    }
}
