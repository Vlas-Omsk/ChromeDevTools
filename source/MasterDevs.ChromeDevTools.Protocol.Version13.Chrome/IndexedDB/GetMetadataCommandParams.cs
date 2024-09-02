using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.IndexedDB
{
	/// <summary>
	/// Gets metadata of an object store.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetMetadataCommandParams: ICommandParams<GetMetadataCommandResult>
	{
		public string MethodName { get; } = ProtocolName.IndexedDB.GetMetadata;
		/// <summary>
		/// At least and at most one of securityOrigin, storageKey must be specified.
		/// Security origin.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SecurityOrigin { get; set; }
		/// <summary>
		/// Storage key.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string StorageKey { get; set; }
		/// <summary>
		/// Database name.
		/// </summary>
		public string DatabaseName { get; set; }
		/// <summary>
		/// Object store name.
		/// </summary>
		public string ObjectStoreName { get; set; }
	}
}
