using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// Gets the entries in an given origin's shared storage.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetSharedStorageEntriesCommandResult : ICommandResult
	{
		/// <summary>
		/// Entries
		/// </summary>
		public SharedStorageEntry[] Entries { get; set; }
	}
}
