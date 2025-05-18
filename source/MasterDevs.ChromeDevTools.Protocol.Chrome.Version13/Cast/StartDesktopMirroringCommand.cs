using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Cast
{
	/// <summary>
	/// Starts mirroring the desktop to the sink.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StartDesktopMirroringCommand: ICommand<StartDesktopMirroringCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Cast.StartDesktopMirroring;
		/// <summary>
		/// SinkName
		/// </summary>
		public string SinkName { get; set; }
	}
}
