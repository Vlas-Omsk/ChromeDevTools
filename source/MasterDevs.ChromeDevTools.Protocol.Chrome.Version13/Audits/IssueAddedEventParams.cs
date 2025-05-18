using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Audits
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
