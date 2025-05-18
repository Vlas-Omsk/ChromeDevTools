using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Storage
{
	/// <summary>
	/// Gets the entries in an given origin's shared storage.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetSharedStorageEntriesCommand: ICommand<GetSharedStorageEntriesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.GetSharedStorageEntries;
		/// <summary>
		/// OwnerOrigin
		/// </summary>
		public string OwnerOrigin { get; set; }
	}
}
