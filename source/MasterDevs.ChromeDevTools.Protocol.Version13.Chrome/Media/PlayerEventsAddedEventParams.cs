using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Media
{
	/// <summary>
	/// Send events as a list, allowing them to be batched on the browser for less
	/// congestion. If batched, events must ALWAYS be in chronological order.
	/// </summary>
	[EventName(ProtocolName.Media.PlayerEventsAdded)]
	[SupportedBy("Chrome")]
	public class PlayerEventsAddedEventParams : IEventParams
	{
		/// <summary>
		/// PlayerId
		/// </summary>
		public string PlayerId { get; set; }
		/// <summary>
		/// Events
		/// </summary>
		public PlayerEvent[] Events { get; set; }
	}
}
