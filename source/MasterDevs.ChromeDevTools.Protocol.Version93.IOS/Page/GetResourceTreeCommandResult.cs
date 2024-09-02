using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Returns present frame / resource tree structure.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetResourceTreeCommandResult : ICommandResult
	{
		/// <summary>
		/// Present frame / resource tree structure.
		/// </summary>
		public FrameResourceTree FrameTree { get; set; }
	}
}
