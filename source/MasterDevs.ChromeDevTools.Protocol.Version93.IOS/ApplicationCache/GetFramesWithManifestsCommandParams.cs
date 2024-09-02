using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.ApplicationCache
{
	/// <summary>
	/// Returns array of frame identifiers with manifest urls for each frame containing a document associated with some application cache.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetFramesWithManifestsCommandParams: ICommandParams<GetFramesWithManifestsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.ApplicationCache.GetFramesWithManifests;
	}
}
