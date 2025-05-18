using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Acknowledges that a screencast frame has been received by the frontend.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ScreencastFrameAckCommand: ICommand<ScreencastFrameAckCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.ScreencastFrameAck;
		/// <summary>
		/// Frame number.
		/// </summary>
		public long SessionId { get; set; }
	}
}
