using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.BackgroundService
{
	[SupportedBy("Chrome")]
	public class BackgroundServiceEvent
	{
		/// <summary>
		/// Timestamp of the event (in seconds).
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// The origin this event belongs to.
		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// The Service Worker ID that initiated the event.
		/// </summary>
		public string ServiceWorkerRegistrationId { get; set; }
		/// <summary>
		/// The Background Service this event belongs to.
		/// </summary>
		public ServiceName Service { get; set; }
		/// <summary>
		/// A description of the event.
		/// </summary>
		public string EventName { get; set; }
		/// <summary>
		/// An identifier that groups related events together.
		/// </summary>
		public string InstanceId { get; set; }
		/// <summary>
		/// A list of event-specific information.
		/// </summary>
		public EventMetadata[] EventMetadata { get; set; }
		/// <summary>
		/// Storage key this event belongs to.
		/// </summary>
		public string StorageKey { get; set; }
	}
}
