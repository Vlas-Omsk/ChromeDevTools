using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Clears the overridden device metrics.
	/// </summary>
	[Obsolete]

	[SupportedBy("Chrome")]
	public class ClearDeviceMetricsOverrideCommandParams: ICommandParams<ClearDeviceMetricsOverrideCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.ClearDeviceMetricsOverride;
	}
}
