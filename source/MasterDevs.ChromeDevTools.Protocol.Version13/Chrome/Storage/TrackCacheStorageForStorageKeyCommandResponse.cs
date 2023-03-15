using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Registers storage key to be notified when an update occurs to its cache storage list.
	/// </summary>
	[CommandResponse(ProtocolName.Storage.TrackCacheStorageForStorageKey)]
	[SupportedBy("Chrome")]
	public class TrackCacheStorageForStorageKeyCommandResponse
	{
	}
}
