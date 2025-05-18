using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DeviceAccess
{
	/// <summary>
	/// Select a device in response to a DeviceAccess.deviceRequestPrompted event.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SelectPromptCommand: ICommand<SelectPromptCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DeviceAccess.SelectPrompt;
		/// <summary>
		/// Id
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// DeviceId
		/// </summary>
		public string DeviceId { get; set; }
	}
}
