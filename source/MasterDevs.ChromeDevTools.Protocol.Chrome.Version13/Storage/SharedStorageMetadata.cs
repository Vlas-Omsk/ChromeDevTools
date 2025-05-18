using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Storage
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
