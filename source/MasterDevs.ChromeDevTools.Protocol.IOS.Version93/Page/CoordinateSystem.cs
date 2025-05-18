using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Page{
	/// <summary>
	/// Coordinate system used by supplied coordinates.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CoordinateSystem
	{
			Viewport,
			Page,
	}
}
