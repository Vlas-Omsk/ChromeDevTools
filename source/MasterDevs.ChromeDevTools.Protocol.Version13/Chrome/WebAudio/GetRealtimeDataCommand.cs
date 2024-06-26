using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	/// Fetch the realtime data from the registered contexts.
	/// </summary>
	[Command(ProtocolName.WebAudio.GetRealtimeData)]
	[SupportedBy("Chrome")]
	public class GetRealtimeDataCommand: IProtocolCommand<GetRealtimeDataCommandResponse>
	{
		/// <summary>
		/// ContextId
		/// </summary>
		public string ContextId { get; set; }
	}
}
