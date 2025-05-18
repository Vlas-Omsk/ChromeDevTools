using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
{
	/// <summary>
	/// Blocks URLs from loading.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetBlockedURLsCommand: ICommand<SetBlockedURLsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.SetBlockedURLs;
		/// <summary>
		/// URL patterns to block. Wildcards ('*') are allowed.
		/// </summary>
		public string[] Urls { get; set; }
	}
}
