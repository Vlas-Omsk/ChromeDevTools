using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.ServiceWorker
{

	[SupportedBy("Chrome")]
	public class SetForceUpdateOnPageLoadCommandParams: ICommandParams<SetForceUpdateOnPageLoadCommandResult>
	{
		public string MethodName { get; } = ProtocolName.ServiceWorker.SetForceUpdateOnPageLoad;
		/// <summary>
		/// ForceUpdateOnPageLoad
		/// </summary>
		public bool ForceUpdateOnPageLoad { get; set; }
	}
}
