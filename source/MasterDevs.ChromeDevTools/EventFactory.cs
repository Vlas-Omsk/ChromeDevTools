using Newtonsoft.Json.Linq;
using System;
using System.Collections.Concurrent;

namespace MasterDevs.ChromeDevTools
{
    internal sealed class EventFactory
    {
        private readonly ConcurrentDictionary<string, Type> _nameTypeMap = new ConcurrentDictionary<string, Type>();

        public IEvent? Create(byte[] responseBytes)
        {
            throw new NotImplementedException();
        }

        public IEvent? Create(string responseText)
        {
            var jObject = JObject.Parse(responseText);
            var methodString = jObject["method"]?.GetSafeString();

            if (methodString == null)
                return null;

            if (!_nameTypeMap.TryGetValue(methodString, out var eventParamsType))
                return null;

            var result = jObject.ToObject(typeof(Event<>).MakeGenericType(eventParamsType)) ??
                throw new Exception("Event was empty");

            return (IEvent)result;
        }

        public void AddEventParamsType(string name, Type type)
        {
            _nameTypeMap.TryAdd(name, type);
        }
    }
}