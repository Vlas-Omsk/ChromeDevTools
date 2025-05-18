using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Browser
{
	/// <summary>
	/// Returns version information.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetVersionCommand: ICommand<GetVersionCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Browser.GetVersion;
	}
}
