using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Cast
{
	/// <summary>
	/// Stops the active Cast session on the sink.
	/// </summary>
	[Command(ProtocolName.Cast.StopCasting)]
	[SupportedBy("Chrome")]
	public class StopCastingCommand: IProtocolCommand<StopCastingCommandResponse>
	{
		/// <summary>
		/// SinkName
		/// </summary>
		public string SinkName { get; set; }
	}
}
