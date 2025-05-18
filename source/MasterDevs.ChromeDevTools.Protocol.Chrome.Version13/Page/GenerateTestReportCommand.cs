using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Generates a report for testing.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GenerateTestReportCommand: ICommand<GenerateTestReportCommandResult>
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
