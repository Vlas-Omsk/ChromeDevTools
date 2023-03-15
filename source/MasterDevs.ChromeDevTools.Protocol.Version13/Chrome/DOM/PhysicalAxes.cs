using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM{
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
