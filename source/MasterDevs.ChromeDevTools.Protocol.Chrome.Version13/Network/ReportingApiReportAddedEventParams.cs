using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
{
	/// <summary>
	/// Is sent whenever a new report is added.
	/// And after 'enableReportingApi' for all existing reports.
	/// </summary>
	[EventName(ProtocolName.Network.ReportingApiReportAdded)]
	[SupportedBy("Chrome")]
	public class ReportingApiReportAddedEventParams : IEventParams
	{
		/// <summary>
		/// Report
		/// </summary>
		public ReportingApiReport Report { get; set; }
	}
}
