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
	public class GetRealtimeDataCommandResult : ICommandResult
	{
		/// <summary>
		/// RealtimeData
		/// </summary>
		public ContextRealtimeData RealtimeData { get; set; }
	}
}
