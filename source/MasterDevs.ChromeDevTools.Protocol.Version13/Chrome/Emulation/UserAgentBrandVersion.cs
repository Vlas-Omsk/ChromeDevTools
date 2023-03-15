using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Used to specify User Agent Cient Hints to emulate. See https://wicg.github.io/ua-client-hints
	/// </summary>
	[SupportedBy("Chrome")]
	public class UserAgentBrandVersion
	{
		/// <summary>
		/// Brand
		/// </summary>
		public string Brand { get; set; }
		/// <summary>
		/// Version
		/// </summary>
		public string Version { get; set; }
	}
}
