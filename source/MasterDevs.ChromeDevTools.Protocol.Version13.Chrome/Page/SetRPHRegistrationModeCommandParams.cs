using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Extensions for Custom Handlers API:
	/// https://html.spec.whatwg.org/multipage/system-state.html#rph-automation
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetRPHRegistrationModeCommandParams: ICommandParams<SetRPHRegistrationModeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.SetRPHRegistrationMode;
		/// <summary>
		/// Mode
		/// </summary>
		public string Mode { get; set; }
	}
}
