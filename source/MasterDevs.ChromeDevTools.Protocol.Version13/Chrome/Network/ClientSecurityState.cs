using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	[SupportedBy("Chrome")]
	public class ClientSecurityState
	{
		/// <summary>
		/// InitiatorIsSecureContext
		/// </summary>
		public bool InitiatorIsSecureContext { get; set; }
		/// <summary>
		/// InitiatorIPAddressSpace
		/// </summary>
		public IPAddressSpace InitiatorIPAddressSpace { get; set; }
		/// <summary>
		/// PrivateNetworkRequestPolicy
		/// </summary>
		public PrivateNetworkRequestPolicy PrivateNetworkRequestPolicy { get; set; }
	}
}
