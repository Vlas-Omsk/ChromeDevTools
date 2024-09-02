using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Resets navigation history for the current page.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ResetNavigationHistoryCommandParams: ICommandParams<ResetNavigationHistoryCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.ResetNavigationHistory;
	}
}
