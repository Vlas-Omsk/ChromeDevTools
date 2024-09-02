using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CacheStorage
{
	/// <summary>
	/// Requests data from cache.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RequestEntriesCommandParams: ICommandParams<RequestEntriesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CacheStorage.RequestEntries;
		/// <summary>
		/// ID of cache to get entries from.
		/// </summary>
		public string CacheId { get; set; }
		/// <summary>
		/// Number of records to skip.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? SkipCount { get; set; }
		/// <summary>
		/// Number of records to fetch.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? PageSize { get; set; }
		/// <summary>
		/// If present, only return the entries containing this substring in the path
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PathFilter { get; set; }
	}
}
