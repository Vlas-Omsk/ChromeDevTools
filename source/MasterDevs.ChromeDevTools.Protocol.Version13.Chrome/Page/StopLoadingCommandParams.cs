using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Force the page stop all navigations and pending resource fetches.
	/// </summary>

	[SupportedBy("Chrome")]
	public class StopLoadingCommandParams: ICommandParams<StopLoadingCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.StopLoading;
	}
}
