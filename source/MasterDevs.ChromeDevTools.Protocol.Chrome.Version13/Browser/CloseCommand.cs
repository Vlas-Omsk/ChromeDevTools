using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Browser
{
	/// <summary>
	/// Close browser gracefully.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CloseCommand: ICommand<CloseCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Browser.Close;
	}
}
