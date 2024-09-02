using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Cast
{
	/// <summary>
	/// Sets a sink to be used when the web page requests the browser to choose a
	/// sink via Presentation API, Remote Playback API, or Cast SDK.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetSinkToUseCommandParams: ICommandParams<SetSinkToUseCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Cast.SetSinkToUse;
		/// <summary>
		/// SinkName
		/// </summary>
		public string SinkName { get; set; }
	}
}
