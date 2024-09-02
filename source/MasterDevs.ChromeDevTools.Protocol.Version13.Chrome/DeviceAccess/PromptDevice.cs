using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DeviceAccess
{
	/// <summary>
	/// Device information displayed in a user prompt to select a device.
	/// </summary>
	[SupportedBy("Chrome")]
	public class PromptDevice
	{
		/// <summary>
		/// Id
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Display name as it appears in a device request user prompt.
		/// </summary>
		public string Name { get; set; }
	}
}
