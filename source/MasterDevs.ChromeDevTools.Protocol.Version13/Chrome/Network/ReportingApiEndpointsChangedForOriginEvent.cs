using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	[Event(ProtocolName.Network.ReportingApiEndpointsChangedForOrigin)]
	[SupportedBy("Chrome")]
	public class ReportingApiEndpointsChangedForOriginEvent
	{
		/// <summary>
		/// Origin of the document(s) which configured the endpoints.
		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// Endpoints
		/// </summary>
		public ReportingApiEndpoint[] Endpoints { get; set; }
	}
}
