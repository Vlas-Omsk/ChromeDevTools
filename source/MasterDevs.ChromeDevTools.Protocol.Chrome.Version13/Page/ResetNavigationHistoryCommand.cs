using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Resets navigation history for the current page.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ResetNavigationHistoryCommand: ICommand<ResetNavigationHistoryCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.ResetNavigationHistory;
	}
}
