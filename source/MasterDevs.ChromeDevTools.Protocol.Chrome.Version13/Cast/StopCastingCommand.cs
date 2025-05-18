using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Cast
{
	/// <summary>
	/// Stops the active Cast session on the sink.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StopCastingCommand: ICommand<StopCastingCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Cast.StopCasting;
		/// <summary>
		/// SinkName
		/// </summary>
		public string SinkName { get; set; }
	}
}
