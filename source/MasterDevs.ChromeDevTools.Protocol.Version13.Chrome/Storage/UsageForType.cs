using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// Usage for a storage type.
	/// </summary>
	[SupportedBy("Chrome")]
	public class UsageForType
	{
		/// <summary>
		/// Name of storage type.
		/// </summary>
		public StorageType StorageType { get; set; }
		/// <summary>
		/// Storage usage (bytes).
		/// </summary>
		public double Usage { get; set; }
	}
}
