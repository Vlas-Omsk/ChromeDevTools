using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Debugger{
	/// <summary>
	/// Enum of possible script languages.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ScriptLanguage
	{
			JavaScript,
			WebAssembly,
	}
}
