using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Media
{
	/// <summary>
	/// Called whenever a player is created, or when a new agent joins and receives
	/// a list of active players. If an agent is restored, it will receive the full
	/// list of player ids and all events again.
	/// </summary>
	[EventName(ProtocolName.Media.PlayersCreated)]
	[SupportedBy("Chrome")]
	public class PlayersCreatedEventParams : IEventParams
	{
		/// <summary>
		/// Players
		/// </summary>
		public string[] Players { get; set; }
	}
}
