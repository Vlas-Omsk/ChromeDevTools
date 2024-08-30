using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CacheStorage
{
	/// <summary>
	/// Deletes a cache entry.
	/// </summary>
	[Command(ProtocolName.CacheStorage.DeleteEntry)]
	[SupportedBy("Chrome")]
	public class DeleteEntryCommand: ICommandParams<DeleteEntryCommandResponse>
	{
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
