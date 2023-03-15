using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Registers storage key to be notified when an update occurs to its IndexedDB.
	/// </summary>
	[CommandResponse(ProtocolName.Storage.TrackIndexedDBForStorageKey)]
	[SupportedBy("Chrome")]
	public class TrackIndexedDBForStorageKeyCommandResponse
	{
	}
}
