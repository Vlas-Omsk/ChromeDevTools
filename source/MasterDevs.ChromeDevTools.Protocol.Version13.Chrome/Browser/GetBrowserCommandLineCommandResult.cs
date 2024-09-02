using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Browser
{
	/// <summary>
	/// Returns the command line switches for the browser process if, and only if
	/// --enable-automation is on the commandline.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetBrowserCommandLineCommandResult : ICommandResult
	{
		/// <summary>
		/// Commandline parameters
		/// </summary>
		public string[] Arguments { get; set; }
	}
}
