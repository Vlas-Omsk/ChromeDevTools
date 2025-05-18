using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CacheStorage
{
	/// <summary>
	/// Deletes a cache entry.
	/// </summary>

	[SupportedBy("Chrome")]
	public class DeleteEntryCommand: ICommand<DeleteEntryCommandResult>
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
