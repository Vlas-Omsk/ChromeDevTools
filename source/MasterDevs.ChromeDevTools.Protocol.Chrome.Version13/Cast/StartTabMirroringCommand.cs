using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Cast
{
	/// <summary>
	/// Starts mirroring the tab to the sink.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StartTabMirroringCommand: ICommand<StartTabMirroringCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Cast.StartTabMirroring;
		/// <summary>
		/// SinkName
		/// </summary>
		public string SinkName { get; set; }
	}
}
