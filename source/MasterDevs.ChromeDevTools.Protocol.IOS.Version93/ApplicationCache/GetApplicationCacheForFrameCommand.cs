using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.ApplicationCache
{
	/// <summary>
	/// Returns relevant application cache data for the document in given frame.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetApplicationCacheForFrameCommand: ICommand<GetApplicationCacheForFrameCommandResult>
	{
		public string MethodName { get; } = ProtocolName.ApplicationCache.GetApplicationCacheForFrame;
		/// <summary>
		/// Identifier of the frame containing document whose application cache is retrieved.
		/// </summary>
		public string FrameId { get; set; }
	}
}
