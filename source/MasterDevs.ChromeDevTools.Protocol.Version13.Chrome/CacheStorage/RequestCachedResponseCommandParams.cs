using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CacheStorage
{
	/// <summary>
	/// Fetches cache entry.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RequestCachedResponseCommandParams: ICommandParams<RequestCachedResponseCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CacheStorage.RequestCachedResponse;
		/// <summary>
		/// Id of cache that contains the entry.
		/// </summary>
		public string CacheId { get; set; }
		/// <summary>
		/// URL spec of the request.
		/// </summary>
		public string RequestURL { get; set; }
		/// <summary>
		/// headers of the request.
		/// </summary>
		public Header[] RequestHeaders { get; set; }
	}
}
