using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Returns present frame tree structure.
	/// </summary>
	[CommandResponse(ProtocolName.Page.GetFrameTree)]
	[SupportedBy("Chrome")]
	public class GetFrameTreeCommandResponse
	{
		/// <summary>
		/// Present frame tree structure.
		/// </summary>
		public FrameTree FrameTree { get; set; }
	}
}
