using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.ServiceWorker
{

	[SupportedBy("Chrome")]
	public class SetForceUpdateOnPageLoadCommand: ICommand<SetForceUpdateOnPageLoadCommandResult>
	{
		public string MethodName { get; } = ProtocolName.ServiceWorker.SetForceUpdateOnPageLoad;
		/// <summary>
		/// ForceUpdateOnPageLoad
		/// </summary>
		public bool ForceUpdateOnPageLoad { get; set; }
	}
}
