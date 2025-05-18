using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM{
	/// <summary>
	/// Document compatibility mode.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CompatibilityMode
	{
			QuirksMode,
			LimitedQuirksMode,
			NoQuirksMode,
	}
}
