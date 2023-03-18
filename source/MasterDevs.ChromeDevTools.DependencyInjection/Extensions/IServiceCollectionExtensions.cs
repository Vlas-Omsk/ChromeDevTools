using Microsoft.Extensions.DependencyInjection;

namespace MasterDevs.ChromeDevTools
{
    public static class IServiceCollectionExtensions
    {
        public static void AddChromeDevTools(this IServiceCollection self)
        {
            self.AddSingleton<IChromeSessionFactory, ChromeSessionFactory>();
            self.AddSingleton<IChromeProcessFactory, ChromeProcessFactory>(
                x => new ChromeProcessFactory(
                    x.GetRequiredService<IChromeSessionFactory>()
                )
            );
        }
    }
}
