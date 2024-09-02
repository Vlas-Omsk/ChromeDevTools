using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Cast
{
	/// <summary>
	/// Starts mirroring the desktop to the sink.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StartDesktopMirroringCommandParams: ICommandParams<StartDesktopMirroringCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Cast.StartDesktopMirroring;
		/// <summary>
		/// SinkName
		/// </summary>
		public string SinkName { get; set; }
	}
}
