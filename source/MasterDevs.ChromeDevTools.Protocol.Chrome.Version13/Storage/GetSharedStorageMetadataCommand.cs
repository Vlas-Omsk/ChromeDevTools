using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Storage
{
	/// <summary>
	/// Gets metadata for an origin's shared storage.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetSharedStorageMetadataCommand: ICommand<GetSharedStorageMetadataCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.GetSharedStorageMetadata;
		/// <summary>
		/// OwnerOrigin
		/// </summary>
		public string OwnerOrigin { get; set; }
	}
}
