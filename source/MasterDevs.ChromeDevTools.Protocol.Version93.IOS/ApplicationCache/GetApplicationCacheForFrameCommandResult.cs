using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.ApplicationCache
{
	/// <summary>
	/// Returns relevant application cache data for the document in given frame.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetApplicationCacheForFrameCommandResult : ICommandResult
	{
		/// <summary>
		/// Relevant application cache data for the document in given frame.
		/// </summary>
		public ApplicationCache ApplicationCache { get; set; }
	}
}
