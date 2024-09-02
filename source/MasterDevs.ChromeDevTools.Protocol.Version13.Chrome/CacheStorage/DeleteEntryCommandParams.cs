using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CacheStorage
{
	/// <summary>
	/// Deletes a cache entry.
	/// </summary>

	[SupportedBy("Chrome")]
	public class DeleteEntryCommandParams: ICommandParams<DeleteEntryCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CacheStorage.DeleteEntry;
		/// <summary>
		/// Id of cache where the entry will be deleted.
		/// </summary>
		public string CacheId { get; set; }
		/// <summary>
		/// URL spec of the request.
		/// </summary>
		public string Request { get; set; }
	}
}
