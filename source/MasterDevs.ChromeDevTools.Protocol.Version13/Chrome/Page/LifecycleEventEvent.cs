using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Fired for top level page lifecycle events such as navigation, load, paint, etc.
	/// </summary>
	[Event(ProtocolName.Page.LifecycleEvent)]
	[SupportedBy("Chrome")]
	public class LifecycleEventEvent
	{
		/// <summary>
		/// Id of the frame.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Loader identifier. Empty string if the request is fetched from worker.
		/// </summary>
		public string LoaderId { get; set; }
		/// <summary>
		/// Name
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Timestamp
		/// </summary>
		public double Timestamp { get; set; }
	}
}
