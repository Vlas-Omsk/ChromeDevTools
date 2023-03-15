using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PermissionSetting
	{
			Granted,
			Denied,
			Prompt,
	}
}
