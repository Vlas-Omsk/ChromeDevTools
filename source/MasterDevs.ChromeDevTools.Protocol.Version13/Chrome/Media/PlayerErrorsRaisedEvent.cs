using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Media
{
	/// <summary>
	/// Send a list of any errors that need to be delivered.
	/// </summary>
	[Event(ProtocolName.Media.PlayerErrorsRaised)]
	[SupportedBy("Chrome")]
	public class PlayerErrorsRaisedEvent
	{
		/// <summary>
		/// PlayerId
		/// </summary>
		public string PlayerId { get; set; }
		/// <summary>
		/// Errors
		/// </summary>
		public PlayerError[] Errors { get; set; }
	}
}
