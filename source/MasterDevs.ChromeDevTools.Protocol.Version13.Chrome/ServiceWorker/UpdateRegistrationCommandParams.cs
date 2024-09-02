using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.ServiceWorker
{

	[SupportedBy("Chrome")]
	public class UpdateRegistrationCommandParams: ICommandParams<UpdateRegistrationCommandResult>
	{
		public string MethodName { get; } = ProtocolName.ServiceWorker.UpdateRegistration;
		/// <summary>
		/// ScopeURL
		/// </summary>
		public string ScopeURL { get; set; }
	}
}
