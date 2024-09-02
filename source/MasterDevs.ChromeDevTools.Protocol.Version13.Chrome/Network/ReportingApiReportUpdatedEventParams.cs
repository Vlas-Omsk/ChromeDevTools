using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	[EventName(ProtocolName.Network.ReportingApiReportUpdated)]
	[SupportedBy("Chrome")]
	public class ReportingApiReportUpdatedEventParams : IEventParams
	{
		/// <summary>
		/// Report
		/// </summary>
		public ReportingApiReport Report { get; set; }
	}
}
