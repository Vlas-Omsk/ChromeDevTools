using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	[SupportedBy("Chrome")]
	public class SecurityIsolationStatus
	{
		/// <summary>
		/// Coop
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CrossOriginOpenerPolicyStatus Coop { get; set; }
		/// <summary>
		/// Coep
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CrossOriginEmbedderPolicyStatus Coep { get; set; }
	}
}
