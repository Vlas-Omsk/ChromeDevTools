using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.WebAudio
{
	/// <summary>
	/// Fetch the realtime data from the registered contexts.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetRealtimeDataCommandParams: ICommandParams<GetRealtimeDataCommandResult>
	{
		public string MethodName { get; } = ProtocolName.WebAudio.GetRealtimeData;
		/// <summary>
		/// ContextId
		/// </summary>
		public string ContextId { get; set; }
	}
}
