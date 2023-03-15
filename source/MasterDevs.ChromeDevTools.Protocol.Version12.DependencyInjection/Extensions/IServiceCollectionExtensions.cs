using Microsoft.Extensions.DependencyInjection;

namespace MasterDevs.ChromeDevTools.Protocol
{
    public static class IServiceCollectionExtensions
    {
        public static void AddChromeDevToolsProtocol(this IServiceCollection self)
        {
            self.AddSingleton<IMethodTypeMap, MethodTypeMap>();
            self.AddSingleton<ICommonCommandsExecutor, CommonCommandsExecutor>();
        }

        public static void AddChromeDevToolsProtocol(this IServiceCollection self, string alias)
        {
            self.AddSingleton<IMethodTypeMap, MethodTypeMap>(x => new MethodTypeMap(alias));
            self.AddSingleton<ICommonCommandsExecutor, CommonCommandsExecutor>();
        }
    }
}
