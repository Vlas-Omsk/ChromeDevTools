using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Cast
{
	/// <summary>
	/// Sets a sink to be used when the web page requests the browser to choose a
	/// sink via Presentation API, Remote Playback API, or Cast SDK.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetSinkToUseCommand: ICommand<SetSinkToUseCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Cast.SetSinkToUse;
		/// <summary>
		/// SinkName
		/// </summary>
		public string SinkName { get; set; }
	}
}
