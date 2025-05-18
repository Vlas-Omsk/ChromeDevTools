using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Returns navigation history for the current page.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetNavigationHistoryCommand: ICommand<GetNavigationHistoryCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.GetNavigationHistory;
	}
}
