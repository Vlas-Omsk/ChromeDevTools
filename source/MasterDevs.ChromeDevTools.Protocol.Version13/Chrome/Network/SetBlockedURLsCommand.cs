using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Blocks URLs from loading.
	/// </summary>
	[Command(ProtocolName.Network.SetBlockedURLs)]
	[SupportedBy("Chrome")]
	public class SetBlockedURLsCommand: ICommandParams<SetBlockedURLsCommandResponse>
	{
		/// <summary>
		/// URL patterns to block. Wildcards ('*') are allowed.
		/// </summary>
		public string[] Urls { get; set; }
	}
}
