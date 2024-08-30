using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.StartWorker)]
	[SupportedBy("Chrome")]
	public class StartWorkerCommand: ICommandParams<StartWorkerCommandResponse>
	{
		/// <summary>
		/// ScopeURL
		/// </summary>
		public string ScopeURL { get; set; }
	}
}
