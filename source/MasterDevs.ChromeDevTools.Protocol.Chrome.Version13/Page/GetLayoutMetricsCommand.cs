using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Returns metrics relating to the layouting of the page, such as viewport bounds/scale.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetLayoutMetricsCommand: ICommand<GetLayoutMetricsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.GetLayoutMetrics;
	}
}
