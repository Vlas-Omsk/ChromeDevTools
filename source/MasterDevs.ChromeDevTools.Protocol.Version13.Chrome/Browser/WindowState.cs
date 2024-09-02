using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Browser{
	/// <summary>
	/// The state of the browser window.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum WindowState
	{
			Normal,
			Minimized,
			Maximized,
			Fullscreen,
	}
}
