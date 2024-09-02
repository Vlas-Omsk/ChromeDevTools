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
	public class GetSharedStorageMetadataCommandResult : ICommandResult
	{
		/// <summary>
		/// Metadata
		/// </summary>
		public SharedStorageMetadata Metadata { get; set; }
	}
}
