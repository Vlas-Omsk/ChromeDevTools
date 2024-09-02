using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Cast
{
	/// <summary>
	/// Starts mirroring the tab to the sink.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StartTabMirroringCommandParams: ICommandParams<StartTabMirroringCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Cast.StartTabMirroring;
		/// <summary>
		/// SinkName
		/// </summary>
		public string SinkName { get; set; }
	}
}
