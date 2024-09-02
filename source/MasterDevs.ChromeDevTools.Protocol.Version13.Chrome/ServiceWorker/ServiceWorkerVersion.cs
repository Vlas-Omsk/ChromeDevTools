using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.ServiceWorker
{
	/// <summary>
	/// ServiceWorker version.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ServiceWorkerVersion
	{
		/// <summary>
		/// VersionId
		/// </summary>
		public string VersionId { get; set; }
		/// <summary>
		/// RegistrationId
		/// </summary>
		public string RegistrationId { get; set; }
		/// <summary>
		/// ScriptURL
		/// </summary>
		public string ScriptURL { get; set; }
		/// <summary>
		/// RunningStatus
		/// </summary>
		public ServiceWorkerVersionRunningStatus RunningStatus { get; set; }
		/// <summary>
		/// Status
		/// </summary>
		public ServiceWorkerVersionStatus Status { get; set; }
		/// <summary>
		/// The Last-Modified header value of the main script.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double ScriptLastModified { get; set; }
		/// <summary>
		/// The time at which the response headers of the main script were received from the server.
		/// For cached script it is the last time the cache entry was validated.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double ScriptResponseTime { get; set; }
		/// <summary>
		/// ControlledClients
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] ControlledClients { get; set; }
		/// <summary>
		/// TargetId
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TargetId { get; set; }
	}
}
