using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	[EventName(ProtocolName.Network.ReportingApiEndpointsChangedForOrigin)]
	[SupportedBy("Chrome")]
	public class ReportingApiEndpointsChangedForOriginEventParams : IEventParams
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
