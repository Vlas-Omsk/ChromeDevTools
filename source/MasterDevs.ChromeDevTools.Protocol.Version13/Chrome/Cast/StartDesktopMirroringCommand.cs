using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Cast
{
	/// <summary>
	/// Starts mirroring the desktop to the sink.
	/// </summary>
	[Command(ProtocolName.Cast.StartDesktopMirroring)]
	[SupportedBy("Chrome")]
	public class StartDesktopMirroringCommand: IProtocolCommand<StartDesktopMirroringCommandResponse>
	{
		/// <summary>
		/// SinkName
		/// </summary>
		public string SinkName { get; set; }
	}
}
