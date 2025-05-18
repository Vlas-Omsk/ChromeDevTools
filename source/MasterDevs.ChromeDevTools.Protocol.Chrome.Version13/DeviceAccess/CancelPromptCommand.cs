using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DeviceAccess
{
	/// <summary>
	/// Cancel a prompt in response to a DeviceAccess.deviceRequestPrompted event.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CancelPromptCommand: ICommand<CancelPromptCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DeviceAccess.CancelPrompt;
		/// <summary>
		/// Id
		/// </summary>
		public string Id { get; set; }
	}
}
