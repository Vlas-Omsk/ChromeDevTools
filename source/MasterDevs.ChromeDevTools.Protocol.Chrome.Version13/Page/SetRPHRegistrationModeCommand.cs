using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Extensions for Custom Handlers API:
	/// https://html.spec.whatwg.org/multipage/system-state.html#rph-automation
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetRPHRegistrationModeCommand: ICommand<SetRPHRegistrationModeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.SetRPHRegistrationMode;
		/// <summary>
		/// Mode
		/// </summary>
		public string Mode { get; set; }
	}
}
