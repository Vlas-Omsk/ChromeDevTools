using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Audits
{
	/// <summary>
	/// Runs the contrast check for the target page. Found issues are reported
	/// using Audits.issueAdded event.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CheckContrastCommandParams: ICommandParams<CheckContrastCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Audits.CheckContrast;
		/// <summary>
		/// Whether to report WCAG AAA level issues. Default is false.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ReportAAA { get; set; }
	}
}
