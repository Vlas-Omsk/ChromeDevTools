using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Media
{
	/// <summary>
	/// Send a list of any messages that need to be delivered.
	/// </summary>
	[EventName(ProtocolName.Media.PlayerMessagesLogged)]
	[SupportedBy("Chrome")]
	public class PlayerMessagesLoggedEventParams : IEventParams
	{
		/// <summary>
		/// PlayerId
		/// </summary>
		public string PlayerId { get; set; }
		/// <summary>
		/// Messages
		/// </summary>
		public PlayerMessage[] Messages { get; set; }
	}
}
