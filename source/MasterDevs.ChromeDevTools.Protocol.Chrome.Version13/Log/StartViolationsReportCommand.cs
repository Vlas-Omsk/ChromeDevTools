using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Log
{
	/// <summary>
	/// start violation reporting.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StartViolationsReportCommand: ICommand<StartViolationsReportCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Log.StartViolationsReport;
		/// <summary>
		/// Configuration for violations.
		/// </summary>
		public ViolationSetting[] Config { get; set; }
	}
}
