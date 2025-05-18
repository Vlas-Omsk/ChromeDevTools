using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Reflection;

namespace MasterDevs.ChromeDevTools.Remote.Serialization
{
    internal sealed class MessageContractResolver : DefaultContractResolver
    {
        protected override string ResolvePropertyName(string propertyName)
        {
            if (string.IsNullOrEmpty(propertyName))
            {
                return propertyName;
            }

            if (1 == propertyName.Length)
            {
                return char.ToLowerInvariant(propertyName[0]).ToString();
            }

            return char.ToLowerInvariant(propertyName[0]) + propertyName.Substring(1);
        }

        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var prop = base.CreateProperty(member, memberSerialization);

            // Add support for properties with private setters; for example, Response<T>.Result has a private setter and its
            // value is not assigned by default.
            if (!prop.Writable)
            {
                var property = member as PropertyInfo;

                if (property != null)
                {
                    var hasPrivateSetter = property.GetSetMethod(true) != null;
                    prop.Writable = hasPrivateSetter;
                }
            }

            return prop;
        }
    }
}