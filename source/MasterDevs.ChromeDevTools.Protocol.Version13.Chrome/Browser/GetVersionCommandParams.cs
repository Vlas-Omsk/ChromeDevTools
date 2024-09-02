using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Browser
{
	/// <summary>
	/// Returns version information.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetVersionCommandParams: ICommandParams<GetVersionCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Browser.GetVersion;
	}
}
