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
	public class GetApplicationCacheForFrameCommandParams: ICommandParams<GetApplicationCacheForFrameCommandResult>
	{
		public string MethodName { get; } = ProtocolName.ApplicationCache.GetApplicationCacheForFrame;
		/// <summary>
		/// Identifier of the frame containing document whose application cache is retrieved.
		/// </summary>
		public string FrameId { get; set; }
	}
}
