using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.DOM{
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
