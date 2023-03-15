using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Shared storage was accessed by the associated page.
	/// The following parameters are included in all events.
	/// </summary>
	[Event(ProtocolName.Storage.SharedStorageAccessed)]
	[SupportedBy("Chrome")]
	public class SharedStorageAccessedEvent
	{
		/// <summary>
		/// Time of the access.
		/// </summary>
		public double AccessTime { get; set; }
		/// <summary>
		/// Enum value indicating the Shared Storage API method invoked.
		/// </summary>
		public SharedStorageAccessType Type { get; set; }
		/// <summary>
		/// DevTools Frame Token for the primary frame tree's root.
		/// </summary>
		public string MainFrameId { get; set; }
		/// <summary>
		/// Serialized origin for the context that invoked the Shared Storage API.
		/// </summary>
		public string OwnerOrigin { get; set; }
		/// <summary>
		/// The sub-parameters warapped by `params` are all optional and their
		/// presence/absence depends on `type`.
		/// </summary>
		public SharedStorageAccessParams Params { get; set; }
	}
}
