using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Fired once when parsing the .wbn file has failed.
	/// </summary>
	[EventName(ProtocolName.Network.SubresourceWebBundleMetadataError)]
	[SupportedBy("Chrome")]
	public class SubresourceWebBundleMetadataErrorEventParams : IEventParams
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
