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
	public class GetSharedStorageMetadataCommandResult : ICommandResult
	{
		/// <summary>
		/// Metadata
		/// </summary>
		public SharedStorageMetadata Metadata { get; set; }
	}
}
