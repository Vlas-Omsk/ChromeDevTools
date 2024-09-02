using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Blocks URLs from loading.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetBlockedURLsCommandParams: ICommandParams<SetBlockedURLsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.SetBlockedURLs;
		/// <summary>
		/// URL patterns to block. Wildcards ('*') are allowed.
		/// </summary>
		public string[] Urls { get; set; }
	}
}
