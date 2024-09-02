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
	public class RequestDataCommandResult : ICommandResult
	{
		/// <summary>
		/// Array of object store data entries.
		/// </summary>
		public DataEntry[] ObjectStoreDataEntries { get; set; }
		/// <summary>
		/// If true, there are more entries to fetch in the given range.
		/// </summary>
		public bool HasMore { get; set; }
	}
}
