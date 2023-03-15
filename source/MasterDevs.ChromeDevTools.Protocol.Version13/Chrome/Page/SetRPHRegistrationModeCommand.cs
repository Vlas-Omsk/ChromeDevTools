using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Extensions for Custom Handlers API:
	/// https://html.spec.whatwg.org/multipage/system-state.html#rph-automation
	/// </summary>
	[Command(ProtocolName.Page.SetRPHRegistrationMode)]
	[SupportedBy("Chrome")]
	public class SetRPHRegistrationModeCommand: IProtocolCommand<SetRPHRegistrationModeCommandResponse>
	{
		/// <summary>
		/// Mode
		/// </summary>
		public string Mode { get; set; }
	}
}
