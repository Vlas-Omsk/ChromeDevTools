using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DeviceAccess
{
	/// <summary>
	/// Select a device in response to a DeviceAccess.deviceRequestPrompted event.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SelectPromptCommandParams: ICommandParams<SelectPromptCommandResult>
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
