using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// Deletes entry for `key` (if it exists) for a given origin's shared storage.
	/// </summary>

	[SupportedBy("Chrome")]
	public class DeleteSharedStorageEntryCommandResult : ICommandResult
	{
	}
}
