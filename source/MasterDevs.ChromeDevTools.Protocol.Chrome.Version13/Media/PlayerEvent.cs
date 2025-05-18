using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Media
{
	/// <summary>
	/// Corresponds to kMediaEventTriggered
	/// </summary>
	[SupportedBy("Chrome")]
	public class PlayerEvent
	{
		/// <summary>
		/// Timestamp
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Value
		/// </summary>
		public string Value { get; set; }
	}
}
