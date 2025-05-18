using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Debugger
{
	/// <summary>
	/// Sets overlay message.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetOverlayMessageCommand: ICommand<SetOverlayMessageCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.SetOverlayMessage;
		/// <summary>
		/// Overlay message to display when paused in debugger.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Message { get; set; }
	}
}
