using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Browser
{
	/// <summary>
	/// Close browser gracefully.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CloseCommandParams: ICommandParams<CloseCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Browser.Close;
	}
}
