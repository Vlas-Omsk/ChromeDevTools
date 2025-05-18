using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Storage
{
	/// <summary>
	/// Sets entry with `key` and `value` for a given origin's shared storage.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetSharedStorageEntryCommandResult : ICommandResult
	{
	}
}
