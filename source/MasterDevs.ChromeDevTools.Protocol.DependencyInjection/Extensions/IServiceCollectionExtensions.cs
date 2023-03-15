using Microsoft.Extensions.DependencyInjection;

namespace MasterDevs.ChromeDevTools.Protocol
{
    public static class IServiceCollectionExtensions
    {
        public static void AddChromeDevToolsProtocol(this IServiceCollection self)
        {
            self.AddSingleton<IMethodTypeMap, MethodTypeMap>();
        }

        public static void AddChromeDevToolsProtocol(this IServiceCollection self, string alias)
        {
            self.AddSingleton<IMethodTypeMap, MethodTypeMap>(x => new MethodTypeMap(alias));
        }
    }
}
