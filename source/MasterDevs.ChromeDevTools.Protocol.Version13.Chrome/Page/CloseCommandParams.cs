using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Tries to close page, running its beforeunload hooks, if any.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CloseCommandParams: ICommandParams<CloseCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.Close;
	}
}
