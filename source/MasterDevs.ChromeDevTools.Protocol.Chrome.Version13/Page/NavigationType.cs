using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page{
	/// <summary>
	/// The type of a frameNavigated event.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum NavigationType
	{
			Navigation,
			BackForwardCacheRestore,
	}
}
