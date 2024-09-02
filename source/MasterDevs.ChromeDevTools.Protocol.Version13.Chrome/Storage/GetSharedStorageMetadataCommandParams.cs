using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// Gets metadata for an origin's shared storage.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetSharedStorageMetadataCommandParams: ICommandParams<GetSharedStorageMetadataCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Storage.GetSharedStorageMetadata;
		/// <summary>
		/// OwnerOrigin
		/// </summary>
		public string OwnerOrigin { get; set; }
	}
}
