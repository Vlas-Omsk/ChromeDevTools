using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Deletes entry for `key` (if it exists) for a given origin's shared storage.
	/// </summary>
	[CommandResponse(ProtocolName.Storage.DeleteSharedStorageEntry)]
	[SupportedBy("Chrome")]
	public class DeleteSharedStorageEntryCommandResponse
	{
	}
}
