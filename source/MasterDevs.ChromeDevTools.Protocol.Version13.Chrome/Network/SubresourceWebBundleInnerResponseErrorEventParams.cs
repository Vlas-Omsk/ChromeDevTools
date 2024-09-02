using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Fired when request for resources within a .wbn file failed.
	/// </summary>
	[EventName(ProtocolName.Network.SubresourceWebBundleInnerResponseError)]
	[SupportedBy("Chrome")]
	public class SubresourceWebBundleInnerResponseErrorEventParams : IEventParams
	{
		/// <summary>
		/// Request identifier of the subresource request
		/// </summary>
		public string InnerRequestId { get; set; }
		/// <summary>
		/// URL of the subresource resource.
		/// </summary>
		public string InnerRequestURL { get; set; }
		/// <summary>
		/// Error message
		/// </summary>
		public string ErrorMessage { get; set; }
		/// <summary>
		/// Bundle request identifier. Used to match this information to another event.
		/// This made be absent in case when the instrumentation was enabled only
		/// after webbundle was parsed.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BundleRequestId { get; set; }
	}
}
