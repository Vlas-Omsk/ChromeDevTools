using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.IndexedDB
{
	/// <summary>
	/// Requests data from object store or index.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RequestDataCommandParams: ICommandParams<RequestDataCommandResult>
	{
		public string MethodName { get; } = ProtocolName.IndexedDB.RequestData;
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
		/// <summary>
		/// Index name, empty string for object store data requests.
		/// </summary>
		public string IndexName { get; set; }
		/// <summary>
		/// Number of records to skip.
		/// </summary>
		public long SkipCount { get; set; }
		/// <summary>
		/// Number of records to fetch.
		/// </summary>
		public long PageSize { get; set; }
		/// <summary>
		/// Key range.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public KeyRange KeyRange { get; set; }
	}
}
