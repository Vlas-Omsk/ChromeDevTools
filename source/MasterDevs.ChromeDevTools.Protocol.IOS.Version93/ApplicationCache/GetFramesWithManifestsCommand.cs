using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.ApplicationCache
{
	/// <summary>
	/// Returns array of frame identifiers with manifest urls for each frame containing a document associated with some application cache.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetFramesWithManifestsCommand: ICommand<GetFramesWithManifestsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.ApplicationCache.GetFramesWithManifests;
	}
}
