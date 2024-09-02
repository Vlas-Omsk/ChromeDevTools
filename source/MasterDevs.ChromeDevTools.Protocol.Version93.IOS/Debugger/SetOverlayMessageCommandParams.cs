using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Debugger
{
	/// <summary>
	/// Sets overlay message.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetOverlayMessageCommandParams: ICommandParams<SetOverlayMessageCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.SetOverlayMessage;
		/// <summary>
		/// Overlay message to display when paused in debugger.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Message { get; set; }
	}
}
