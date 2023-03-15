using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// HTTP response data.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Response
	{
		/// <summary>
		/// Response URL. This URL can be different from CachedResource.url in case of redirect.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// HTTP response status code.
		/// </summary>
		public long Status { get; set; }
		/// <summary>
		/// HTTP response status text.
		/// </summary>
		public string StatusText { get; set; }
		/// <summary>
		/// HTTP response headers.
		/// </summary>
		public Dictionary<string, string> Headers { get; set; }
		/// <summary>
		/// HTTP response headers text. This has been replaced by the headers in Network.responseReceivedExtraInfo.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string HeadersText { get; set; }
		/// <summary>
		/// Resource mimeType as determined by the browser.
		/// </summary>
		public string MimeType { get; set; }
		/// <summary>
		/// Refined HTTP request headers that were actually transmitted over the network.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Dictionary<string, string> RequestHeaders { get; set; }
		/// <summary>
		/// HTTP request headers text. This has been replaced by the headers in Network.requestWillBeSentExtraInfo.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string RequestHeadersText { get; set; }
		/// <summary>
		/// Specifies whether physical connection was actually reused for this request.
		/// </summary>
		public bool ConnectionReused { get; set; }
		/// <summary>
		/// Physical connection id that was actually used for this request.
		/// </summary>
		public double ConnectionId { get; set; }
		/// <summary>
		/// Remote IP address.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string RemoteIPAddress { get; set; }
		/// <summary>
		/// Remote port.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? RemotePort { get; set; }
		/// <summary>
		/// Specifies that the request was served from the disk cache.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? FromDiskCache { get; set; }
		/// <summary>
		/// Specifies that the request was served from the ServiceWorker.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? FromServiceWorker { get; set; }
		/// <summary>
		/// Specifies that the request was served from the prefetch cache.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? FromPrefetchCache { get; set; }
		/// <summary>
		/// Total number of bytes received for this request so far.
		/// </summary>
		public double EncodedDataLength { get; set; }
		/// <summary>
		/// Timing information for the given request.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ResourceTiming Timing { get; set; }
		/// <summary>
		/// Response source of response from ServiceWorker.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ServiceWorkerResponseSource ServiceWorkerResponseSource { get; set; }
		/// <summary>
		/// The time at which the returned response was generated.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double ResponseTime { get; set; }
		/// <summary>
		/// Cache Storage Cache Name.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string CacheStorageCacheName { get; set; }
		/// <summary>
		/// Protocol used to fetch this request.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Protocol { get; set; }
		/// <summary>
		/// The reason why Chrome uses a specific transport protocol for HTTP semantics.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AlternateProtocolUsage AlternateProtocolUsage { get; set; }
		/// <summary>
		/// Security state of the request resource.
		/// </summary>
		public Security.SecurityState SecurityState { get; set; }
		/// <summary>
		/// Security details for the request.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SecurityDetails SecurityDetails { get; set; }
	}
}
