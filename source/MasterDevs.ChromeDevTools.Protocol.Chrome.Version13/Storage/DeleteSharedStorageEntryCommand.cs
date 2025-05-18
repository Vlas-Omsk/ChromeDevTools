using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Storage
{
	/// <summary>
	/// Deletes entry for `key` (if it exists) for a given origin's shared storage.
	/// </summary>

	[SupportedBy("Chrome")]
	public class DeleteSharedStorageEntryCommand: ICommand<DeleteSharedStorageEntryCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.DeleteSharedStorageEntry;
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
