using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	[SupportedBy("Chrome")]
	public class ReportingApiEndpoint
	{
		/// <summary>
		/// The URL of the endpoint to which reports may be delivered.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Name of the endpoint group.
		/// </summary>
		public string GroupName { get; set; }
	}
}
