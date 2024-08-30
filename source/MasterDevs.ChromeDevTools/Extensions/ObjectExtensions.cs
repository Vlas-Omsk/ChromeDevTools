using System;
using System.Linq;
using System.Reflection;

namespace MasterDevs.ChromeDevTools
{
    internal static class ObjectExtensions
    {
        public static string GetMethod(this object obj)
        {
            if (null == obj)
                return null;

            return GetMethod(obj.GetType());
        }

        public static string GetMethod(this Type type)
        {
            if (null == type)
                return null;

            if (type.GetTypeInfo()
                .GetCustomAttributes(typeof(EventAttribute), true)
                .FirstOrDefault() is EventAttribute eventAttribute)
                return eventAttribute.Name;

            if (type.GetTypeInfo()
                .GetCustomAttributes(typeof(CommandAttribute), true)
                .FirstOrDefault() is CommandAttribute commandAttribute)
                return commandAttribute.Name;

            if (type.GetTypeInfo()
                .GetCustomAttributes(typeof(CommandResponseAttribute), true)
                .FirstOrDefault() is CommandResponseAttribute commandResponseAttribute)
                return commandResponseAttribute.Name;

            // maybe it's generic parameter has a method
            if (type.GetTypeInfo().IsGenericType)
            {
                return type.GenericTypeArguments
                    .FirstOrDefault()
                    .GetMethod();
            }

            throw new Exception("Could not determine the method type for " + type);
        }
    }
}