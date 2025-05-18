using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Log
{
	/// <summary>
	/// Stop violation reporting.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StopViolationsReportCommand: ICommand<StopViolationsReportCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Log.StopViolationsReport;
	}
}
