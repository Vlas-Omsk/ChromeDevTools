using System;
using System.Reflection;

namespace MasterDevs.ChromeDevTools.Protocol
{
    public static class TypeExtensions
    {
        public static string GetEventName(this Type self)
        {
            var eventNameAttribute = self.GetCustomAttribute<EventNameAttribute>();

            if (eventNameAttribute == null)
                throw new InvalidOperationException($"Type should have {nameof(EventNameAttribute)}");

            return eventNameAttribute.Name;
        }
    }
}
