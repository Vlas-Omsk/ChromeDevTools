using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Returns present frame tree structure.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetFrameTreeCommandResult : ICommandResult
	{
		/// <summary>
		/// Present frame tree structure.
		/// </summary>
		public FrameTree FrameTree { get; set; }
	}
}
