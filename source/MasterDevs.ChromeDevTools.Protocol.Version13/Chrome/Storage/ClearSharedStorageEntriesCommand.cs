using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Clears all entries for a given origin's shared storage.
	/// </summary>
	[Command(ProtocolName.Storage.ClearSharedStorageEntries)]
	[SupportedBy("Chrome")]
	public class ClearSharedStorageEntriesCommand: IProtocolCommand<ClearSharedStorageEntriesCommandResponse>
	{
		/// <summary>
		/// OwnerOrigin
		/// </summary>
		public string OwnerOrigin { get; set; }
	}
}
