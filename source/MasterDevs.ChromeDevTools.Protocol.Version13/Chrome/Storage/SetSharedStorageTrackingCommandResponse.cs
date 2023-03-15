using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Enables/disables issuing of sharedStorageAccessed events.
	/// </summary>
	[CommandResponse(ProtocolName.Storage.SetSharedStorageTracking)]
	[SupportedBy("Chrome")]
	public class SetSharedStorageTrackingCommandResponse
	{
	}
}
