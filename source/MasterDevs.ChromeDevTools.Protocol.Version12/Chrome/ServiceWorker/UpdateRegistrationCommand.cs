using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.UpdateRegistration)]
	[SupportedBy("Chrome")]
	public class UpdateRegistrationCommand: IProtocolCommand<UpdateRegistrationCommandResponse>
	{
		/// <summary>
		/// Gets or sets ScopeURL
		/// </summary>
		public string ScopeURL { get; set; }
	}
}
