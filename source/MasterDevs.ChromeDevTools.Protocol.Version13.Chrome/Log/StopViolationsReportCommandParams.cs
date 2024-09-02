using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Log
{
	/// <summary>
	/// Stop violation reporting.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StopViolationsReportCommandParams: ICommandParams<StopViolationsReportCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Log.StopViolationsReport;
	}
}
