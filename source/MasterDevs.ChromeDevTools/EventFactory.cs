using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json.Linq;
using System;

namespace MasterDevs.ChromeDevTools
{
    internal sealed class EventFactory
    {
        public Event<T>? Create<T>(byte[] responseBytes)
            where T : IEventParams
        {
            throw new NotImplementedException();
        }

        public Event<T>? Create<T>(string responseText)
            where T : IEventParams
        {
            var jObject = JObject.Parse(responseText);
            var methodString = jObject["method"]?.GetSafeString();

            if (null == methodString)
                return null;

            var typeInferredFromMethod = _methodTypeMap.GetEvent(methodString);

            if (null == typeInferredFromMethod)
                return null;

            var genericEventType = typeof(Event<>);
            var commandResponseType = genericEventType.MakeGenericType(typeInferredFromMethod);
            var result = jObject.ToObject(commandResponseType);

            return result as Event<T>;
        }
    }
}