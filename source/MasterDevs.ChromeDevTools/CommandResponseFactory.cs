using MasterDevs.ChromeDevTools.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics.CodeAnalysis;

namespace MasterDevs.ChromeDevTools
{
    internal sealed class CommandResponseFactory
    {
        // Used to deserialize command responses from JSON to .NET objects.
        private  static readonly JsonSerializer _serializer = new JsonSerializer()
        {
            ContractResolver = new MessageContractResolver()
        };
        private readonly CommandFactory _commandFactory;
        
        public CommandResponseFactory(CommandFactory commandFactory)
        {
            _commandFactory = commandFactory;
        }

        public ICommandResponse? Create(byte[] responseBytes)
        {
            throw new NotImplementedException();
        }

        public ICommandResponse? Create(string responseText)
        {
            var jObject = JObject.Parse(responseText);

            if (jObject["error"] != null)
                return jObject.ToObject<ErrorResponse>();
            
            if (!TryGetCommandResultType(jObject, out var commandResultType))
                return null;

            return (ICommandResponse?)jObject.ToObject(
                typeof(CommandResponse<>).MakeGenericType(commandResultType),
                _serializer
            ) ?? throw new Exception("Response was empty");
        }

        private bool TryGetCommandResultType(JObject jObject, [NotNullWhen(true)] out Type? type)
        {
            var methodString = jObject["method"]?.GetSafeString();
            var commandIdString = jObject["id"]?.GetSafeString();

            long.TryParse(commandIdString, out var commandId);

            return _commandFactory.TryTakeCommandResultType(commandId, methodString, out type);
        }
    }
}