using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Storage
{
	/// <summary>
	/// Clears all entries for a given origin's shared storage.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ClearSharedStorageEntriesCommand: ICommand<ClearSharedStorageEntriesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.ClearSharedStorageEntries;
		/// <summary>
		/// OwnerOrigin
		/// </summary>
		public string OwnerOrigin { get; set; }
	}
}
