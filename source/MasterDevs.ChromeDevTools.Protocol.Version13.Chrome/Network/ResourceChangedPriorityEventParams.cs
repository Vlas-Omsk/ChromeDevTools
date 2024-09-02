using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Fired when resource loading priority is changed
	/// </summary>
	[EventName(ProtocolName.Network.ResourceChangedPriority)]
	[SupportedBy("Chrome")]
	public class ResourceChangedPriorityEventParams : IEventParams
	{
		/// <summary>
		/// Request identifier.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// New priority
		/// </summary>
		public ResourcePriority NewPriority { get; set; }
		/// <summary>
		/// Timestamp.
		/// </summary>
		public double Timestamp { get; set; }
	}
}
