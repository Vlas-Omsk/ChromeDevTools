using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.ApplicationCache
{
	/// <summary>
	/// Returns manifest URL for document in the given frame.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetManifestForFrameCommand: ICommand<GetManifestForFrameCommandResult>
	{
		public string MethodName { get; } = ProtocolName.ApplicationCache.GetManifestForFrame;
		/// <summary>
		/// Identifier of the frame containing document whose manifest is retrieved.
		/// </summary>
		public string FrameId { get; set; }
	}
}
