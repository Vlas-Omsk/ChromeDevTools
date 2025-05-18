using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Media
{
	/// <summary>
	/// Send a list of any errors that need to be delivered.
	/// </summary>
	[EventName(ProtocolName.Media.PlayerErrorsRaised)]
	[SupportedBy("Chrome")]
	public class PlayerErrorsRaisedEventParams : IEventParams
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
