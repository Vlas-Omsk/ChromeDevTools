using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	/// Requests data from object store or index.
	/// </summary>
	[CommandResponse(ProtocolName.IndexedDB.RequestData)]
	[SupportedBy("Chrome")]
	public class RequestDataCommandResponse
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
