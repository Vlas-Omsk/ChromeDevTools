using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.IndexedDB
{
	/// <summary>
	/// Requests data from object store or index.
	/// </summary>

	[SupportedBy("IOS")]
	public class RequestDataCommandParams: ICommandParams<RequestDataCommandResult>
	{
		public string MethodName { get; } = ProtocolName.IndexedDB.RequestData;
		/// <summary>
		/// Security origin.
		/// </summary>
		public string SecurityOrigin { get; set; }
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
