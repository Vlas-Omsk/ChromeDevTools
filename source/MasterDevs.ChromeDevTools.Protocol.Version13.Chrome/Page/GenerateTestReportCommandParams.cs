using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Generates a report for testing.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GenerateTestReportCommandParams: ICommandParams<GenerateTestReportCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.GenerateTestReport;
		/// <summary>
		/// Message to be displayed in the report.
		/// </summary>
		public string Message { get; set; }
		/// <summary>
		/// Specifies the endpoint group to deliver the report to.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Group { get; set; }
	}
}
