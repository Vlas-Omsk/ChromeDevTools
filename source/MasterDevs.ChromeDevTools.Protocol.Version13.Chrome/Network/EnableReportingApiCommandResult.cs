using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Enables tracking for the Reporting API, events generated by the Reporting API will now be delivered to the client.
	/// Enabling triggers 'reportingApiReportAdded' for all existing reports.
	/// </summary>

	[SupportedBy("Chrome")]
	public class EnableReportingApiCommandResult : ICommandResult
	{
	}
}