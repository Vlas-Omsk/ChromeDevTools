using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Returns metrics relating to the layouting of the page, such as viewport bounds/scale.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetLayoutMetricsCommandParams: ICommandParams<GetLayoutMetricsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.GetLayoutMetrics;
	}
}
