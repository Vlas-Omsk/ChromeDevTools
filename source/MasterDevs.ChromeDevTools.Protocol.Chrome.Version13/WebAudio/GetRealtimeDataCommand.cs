using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.WebAudio
{
	/// <summary>
	/// Fetch the realtime data from the registered contexts.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetRealtimeDataCommand: ICommand<GetRealtimeDataCommandResult>
	{
		public string MethodName { get; } = ProtocolName.WebAudio.GetRealtimeData;
		/// <summary>
		/// ContextId
		/// </summary>
		public string ContextId { get; set; }
	}
}
