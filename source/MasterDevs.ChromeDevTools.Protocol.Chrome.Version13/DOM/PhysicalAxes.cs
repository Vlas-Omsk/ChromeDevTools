using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM{
	/// <summary>
	/// ContainerSelector physical axes
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PhysicalAxes
	{
			Horizontal,
			Vertical,
			Both,
	}
}
