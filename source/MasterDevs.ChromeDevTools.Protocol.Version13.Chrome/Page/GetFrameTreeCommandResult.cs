using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
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
