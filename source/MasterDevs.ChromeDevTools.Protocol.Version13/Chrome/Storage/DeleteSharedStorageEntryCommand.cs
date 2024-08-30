using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Deletes entry for `key` (if it exists) for a given origin's shared storage.
	/// </summary>
	[Command(ProtocolName.Storage.DeleteSharedStorageEntry)]
	[SupportedBy("Chrome")]
	public class DeleteSharedStorageEntryCommand: ICommandParams<DeleteSharedStorageEntryCommandResponse>
	{
		/// <summary>
		/// OwnerOrigin
		/// </summary>
		public string OwnerOrigin { get; set; }
		/// <summary>
		/// Key
		/// </summary>
		public string Key { get; set; }
	}
}
