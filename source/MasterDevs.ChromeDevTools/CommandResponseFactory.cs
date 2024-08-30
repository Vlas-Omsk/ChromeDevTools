using MasterDevs.ChromeDevTools.Protocol;
using MasterDevs.ChromeDevTools.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace MasterDevs.ChromeDevTools
{
    internal sealed class CommandResponseFactory
    {
        private readonly CommandFactory _commandFactory = new CommandFactory();

        /// Used to deserialize command responses from JSON to .NET objects.
        private readonly JsonSerializer _serializer = new JsonSerializer() { ContractResolver = new MessageContractResolver() };

        public CommandResponse<T>? Create<T>(byte[] responseBytes)
            where T : ICommandResult
        {
            throw new NotImplementedException();
        }

        public CommandResponse<T>? Create<T>(string responseText)
            where T : ICommandResult
        {
            var jObject = JObject.Parse(responseText);

            if (null != jObject["error"])
                return jObject.ToObject<ErrorResponse>();
            
            var methodString = GetMethod(jObject);

            if (null == methodString)
                return null;

            var result = jObject.ToObject<CommandResponse<T>>(_serializer);

            return result;
        }

        private string? GetMethod(JObject jObject)
        {
            var methodString = jObject["method"]?.GetSafeString();

            if (null == methodString)
            {
                var commandIdString = jObject["id"]?.GetSafeString();

                if (long.TryParse(commandIdString, out var commandId))
                    methodString = _commandFactory.GetMethod(commandId);
            }

            return methodString;
        }
    }
}