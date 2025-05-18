using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Browser{
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
