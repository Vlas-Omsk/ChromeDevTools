using Microsoft.Extensions.DependencyInjection;

namespace MasterDevs.ChromeDevTools.Local.DependencyInjection
{
    public static class IServiceCollectionExtensions
    {
        public static void AddChromeDevTools(this IServiceCollection self, string chromePath)
        {
            self.AddSingleton<IChromeSessionFactory, ChromeSessionFactory>();
            self.AddSingleton<IChromeProcessFactory, LocalChromeProcessFactory>(
                x => new LocalChromeProcessFactory(
                    x.GetRequiredService<IChromeSessionFactory>(),
                    chromePath
                )
            );
        }
    }
}
