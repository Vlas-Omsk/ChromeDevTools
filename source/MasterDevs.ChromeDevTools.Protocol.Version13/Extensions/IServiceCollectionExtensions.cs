using Microsoft.Extensions.DependencyInjection;

namespace MasterDevs.ChromeDevTools.Protocol
{
    public static class IServiceCollectionExtensions
    {
        public static void AddChromeDevToolsProtocol(this IServiceCollection self)
        {
            self.AddSingleton<IProtocolTypeMap, MethodTypeMap>();
            self.AddSingleton<ICommonCommandsProvider, CommonCommandsExecutor>();
        }

        public static void AddChromeDevToolsProtocol(this IServiceCollection self, string alias)
        {
            self.AddSingleton<IProtocolTypeMap, MethodTypeMap>(x => new MethodTypeMap(alias));
            self.AddSingleton<ICommonCommandsProvider, CommonCommandsExecutor>();
        }
    }
}
