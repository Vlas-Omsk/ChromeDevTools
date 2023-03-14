﻿using Microsoft.Extensions.DependencyInjection;

namespace MasterDevs.ChromeDevTools.DependencyInjection
{
    public static class IServiceCollectionExtensions
    {
        public static void AddChromeDevTools(this IServiceCollection self, string chromePath)
        {
            self.AddSingleton<IChromeSessionFactory, ChromeSessionFactory>();
            self.AddSingleton<IChromeProcessFactory, ChromeProcessFactory>(
                x => new ChromeProcessFactory(
                    x.GetRequiredService<IChromeSessionFactory>(),
                    chromePath
                )
            );
        }
    }
}
