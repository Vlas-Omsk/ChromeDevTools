using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Cast
{
	/// <summary>
	/// Sets a sink to be used when the web page requests the browser to choose a
	/// sink via Presentation API, Remote Playback API, or Cast SDK.
	/// </summary>
	[Command(ProtocolName.Cast.SetSinkToUse)]
	[SupportedBy("Chrome")]
	public class SetSinkToUseCommand: ICommandParams<SetSinkToUseCommandResponse>
	{
		/// <summary>
		/// SinkName
		/// </summary>
		public string SinkName { get; set; }
	}
}
