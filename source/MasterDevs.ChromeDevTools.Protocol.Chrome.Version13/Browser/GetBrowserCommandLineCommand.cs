using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Browser
{
	/// <summary>
	/// Returns the command line switches for the browser process if, and only if
	/// --enable-automation is on the commandline.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetBrowserCommandLineCommand: ICommand<GetBrowserCommandLineCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Browser.GetBrowserCommandLine;
	}
}
