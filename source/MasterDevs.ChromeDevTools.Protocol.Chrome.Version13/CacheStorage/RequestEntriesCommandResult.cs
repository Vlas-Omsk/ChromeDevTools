using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CacheStorage
{
	/// <summary>
	/// Requests data from cache.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RequestEntriesCommandResult : ICommandResult
	{
		/// <summary>
		/// Array of object store data entries.
		/// </summary>
		public DataEntry[] CacheDataEntries { get; set; }
		/// <summary>
		/// Count of returned entries from this storage. If pathFilter is empty, it
		/// is the count of all entries from this storage.
		/// </summary>
		public double ReturnCount { get; set; }
	}
}
