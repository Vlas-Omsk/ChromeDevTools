using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Cast
{
	/// <summary>
	/// Stops the active Cast session on the sink.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StopCastingCommandParams: ICommandParams<StopCastingCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Cast.StopCasting;
		/// <summary>
		/// SinkName
		/// </summary>
		public string SinkName { get; set; }
	}
}
