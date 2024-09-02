using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Acknowledges that a screencast frame has been received by the frontend.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ScreencastFrameAckCommandParams: ICommandParams<ScreencastFrameAckCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.ScreencastFrameAck;
		/// <summary>
		/// Frame number.
		/// </summary>
		public long SessionId { get; set; }
	}
}
