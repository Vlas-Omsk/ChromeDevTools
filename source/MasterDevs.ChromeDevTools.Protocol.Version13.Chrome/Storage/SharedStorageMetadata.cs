using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Storage
{
	/// <summary>
	/// Details for an origin's shared storage.
	/// </summary>
	[SupportedBy("Chrome")]
	public class SharedStorageMetadata
	{
		/// <summary>
		/// CreationTime
		/// </summary>
		public double CreationTime { get; set; }
		/// <summary>
		/// Length
		/// </summary>
		public long Length { get; set; }
		/// <summary>
		/// RemainingBudget
		/// </summary>
		public double RemainingBudget { get; set; }
	}
}
