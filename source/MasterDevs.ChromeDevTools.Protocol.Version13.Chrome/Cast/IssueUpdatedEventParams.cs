using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Cast
{
	/// <summary>
	/// This is fired whenever the outstanding issue/error message changes.
	/// |issueMessage| is empty if there is no issue.
	/// </summary>
	[EventName(ProtocolName.Cast.IssueUpdated)]
	[SupportedBy("Chrome")]
	public class IssueUpdatedEventParams : IEventParams
	{
		/// <summary>
		/// IssueMessage
		/// </summary>
		public string IssueMessage { get; set; }
	}
}
