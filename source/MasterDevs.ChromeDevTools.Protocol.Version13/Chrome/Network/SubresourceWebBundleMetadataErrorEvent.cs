using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Fired once when parsing the .wbn file has failed.
	/// </summary>
	[Event(ProtocolName.Network.SubresourceWebBundleMetadataError)]
	[SupportedBy("Chrome")]
	public class SubresourceWebBundleMetadataErrorEvent
	{
		/// <summary>
		/// Request identifier. Used to match this information to another event.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Error message
		/// </summary>
		public string ErrorMessage { get; set; }
	}
}
