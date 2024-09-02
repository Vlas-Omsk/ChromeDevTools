using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Timeline
{
	/// <summary>
	/// Starts capturing instrumentation events.
	/// </summary>

	[SupportedBy("IOS")]
	public class StartCommandParams: ICommandParams<StartCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Timeline.Start;
		/// <summary>
		/// Samples JavaScript stack traces up to <code>maxCallStackDepth</code>, defaults to 5.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? MaxCallStackDepth { get; set; }
	}
}
