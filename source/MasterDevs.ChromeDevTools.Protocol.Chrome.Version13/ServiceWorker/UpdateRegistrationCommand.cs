using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.ServiceWorker
{

	[SupportedBy("Chrome")]
	public class UpdateRegistrationCommand: ICommand<UpdateRegistrationCommandResult>
	{
		public string MethodName { get; } = ProtocolName.ServiceWorker.UpdateRegistration;
		/// <summary>
		/// ScopeURL
		/// </summary>
		public string ScopeURL { get; set; }
	}
}
