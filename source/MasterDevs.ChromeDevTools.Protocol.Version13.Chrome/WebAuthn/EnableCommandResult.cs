using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.WebAuthn
{
	/// <summary>
	/// Enable the WebAuthn domain and start intercepting credential storage and
	/// retrieval with a virtual authenticator.
	/// </summary>

	[SupportedBy("Chrome")]
	public class EnableCommandResult : ICommandResult
	{
	}
}
