using MasterDevs.ChromeDevTools.Remote.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics.CodeAnalysis;

namespace MasterDevs.ChromeDevTools.Remote
{
    internal sealed class CommandResponseFactory
    {
        // Used to deserialize command responses from JSON to .NET objects.
        private  static readonly JsonSerializer _serializer = new JsonSerializer()
        {
            ContractResolver = new MessageContractResolver()
        };
        private readonly CommandRequestFactory _commandRequestFactory;
        
        public CommandResponseFactory(CommandRequestFactory commandRequestFactory)
        {
            _commandRequestFactory = commandRequestFactory;
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
            var method = jObject["method"]?.GetSafeString();
            var idString = jObject["id"]?.GetSafeString();

            long.TryParse(idString, out var id);

            return _commandRequestFactory.TryTakeCommandResultType(id, method, out type);
        }
    }
}