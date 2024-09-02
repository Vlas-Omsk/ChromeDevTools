using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// Sets entry with `key` and `value` for a given origin's shared storage.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetSharedStorageEntryCommandResult : ICommandResult
	{
	}
}
