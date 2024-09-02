using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Media
{
	/// <summary>
	/// This can be called multiple times, and can be used to set / override /
	/// remove player properties. A null propValue indicates removal.
	/// </summary>
	[EventName(ProtocolName.Media.PlayerPropertiesChanged)]
	[SupportedBy("Chrome")]
	public class PlayerPropertiesChangedEventParams : IEventParams
	{
		/// <summary>
		/// PlayerId
		/// </summary>
		public string PlayerId { get; set; }
		/// <summary>
		/// Properties
		/// </summary>
		public PlayerProperty[] Properties { get; set; }
	}
}
