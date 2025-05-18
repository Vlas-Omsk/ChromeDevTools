using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
{
	/// <summary>
	/// Toggles ignoring of service worker for each request.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetBypassServiceWorkerCommand: ICommand<SetBypassServiceWorkerCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.SetBypassServiceWorker;
		/// <summary>
		/// Bypass service worker and load from network.
		/// </summary>
		public bool Bypass { get; set; }
	}
}
