using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{

	[SupportedBy("Chrome")]
	public class SetPausedInDebuggerMessageCommandParams: ICommandParams<SetPausedInDebuggerMessageCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetPausedInDebuggerMessage;
		/// <summary>
		/// The message to display, also triggers resume and step over controls.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Message { get; set; }
	}
}
