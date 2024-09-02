using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Toggles ignoring of service worker for each request.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetBypassServiceWorkerCommandParams: ICommandParams<SetBypassServiceWorkerCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.SetBypassServiceWorker;
		/// <summary>
		/// Bypass service worker and load from network.
		/// </summary>
		public bool Bypass { get; set; }
	}
}
