using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.ServiceWorker
{

	[SupportedBy("Chrome")]
	public class UnregisterCommandParams: ICommandParams<UnregisterCommandResult>
	{
		public string MethodName { get; } = ProtocolName.ServiceWorker.Unregister;
		/// <summary>
		/// ScopeURL
		/// </summary>
		public string ScopeURL { get; set; }
	}
}
