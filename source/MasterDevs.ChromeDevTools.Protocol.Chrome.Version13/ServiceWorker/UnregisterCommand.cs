using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.ServiceWorker
{

	[SupportedBy("Chrome")]
	public class UnregisterCommand: ICommand<UnregisterCommandResult>
	{
		public string MethodName { get; } = ProtocolName.ServiceWorker.Unregister;
		/// <summary>
		/// ScopeURL
		/// </summary>
		public string ScopeURL { get; set; }
	}
}
