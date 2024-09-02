using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DeviceAccess
{
	/// <summary>
	/// A device request opened a user prompt to select a device. Respond with the
	/// selectPrompt or cancelPrompt command.
	/// </summary>
	[EventName(ProtocolName.DeviceAccess.DeviceRequestPrompted)]
	[SupportedBy("Chrome")]
	public class DeviceRequestPromptedEventParams : IEventParams
	{
		/// <summary>
		/// Id
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Devices
		/// </summary>
		public PromptDevice[] Devices { get; set; }
	}
}
