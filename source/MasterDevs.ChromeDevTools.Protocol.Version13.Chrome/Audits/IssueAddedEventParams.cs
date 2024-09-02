using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Audits
{
	[EventName(ProtocolName.Audits.IssueAdded)]
	[SupportedBy("Chrome")]
	public class IssueAddedEventParams : IEventParams
	{
		/// <summary>
		/// Issue
		/// </summary>
		public InspectorIssue Issue { get; set; }
	}
}
