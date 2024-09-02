using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM{
	/// <summary>
	/// Pseudo element type.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PseudoType
	{
			Before,
			After,
	}
}
