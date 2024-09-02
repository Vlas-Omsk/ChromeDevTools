using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger{
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
