using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// Struct for a single key-value pair in an origin's shared storage.
	/// </summary>
	[SupportedBy("Chrome")]
	public class SharedStorageEntry
	{
		/// <summary>
		/// Key
		/// </summary>
		public string Key { get; set; }
		/// <summary>
		/// Value
		/// </summary>
		public string Value { get; set; }
	}
}
