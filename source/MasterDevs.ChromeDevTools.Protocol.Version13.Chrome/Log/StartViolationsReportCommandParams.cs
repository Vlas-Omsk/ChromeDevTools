using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Log
{
	/// <summary>
	/// start violation reporting.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StartViolationsReportCommandParams: ICommandParams<StartViolationsReportCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Log.StartViolationsReport;
		/// <summary>
		/// Configuration for violations.
		/// </summary>
		public ViolationSetting[] Config { get; set; }
	}
}
