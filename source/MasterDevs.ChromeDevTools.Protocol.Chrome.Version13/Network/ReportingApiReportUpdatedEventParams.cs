using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
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
