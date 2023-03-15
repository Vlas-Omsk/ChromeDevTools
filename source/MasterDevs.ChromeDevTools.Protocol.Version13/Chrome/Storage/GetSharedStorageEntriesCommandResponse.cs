using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Gets the entries in an given origin's shared storage.
	/// </summary>
	[CommandResponse(ProtocolName.Storage.GetSharedStorageEntries)]
	[SupportedBy("Chrome")]
	public class GetSharedStorageEntriesCommandResponse
	{
		/// <summary>
		/// Entries
		/// </summary>
		public SharedStorageEntry[] Entries { get; set; }
	}
}
