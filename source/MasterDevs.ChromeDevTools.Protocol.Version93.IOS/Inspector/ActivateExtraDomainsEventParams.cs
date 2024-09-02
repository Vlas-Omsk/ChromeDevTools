using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Inspector
{
	/// <summary>
	/// Fired when the backend has alternate domains that need to be activated.
	/// </summary>
	[EventName(ProtocolName.Inspector.ActivateExtraDomains)]
	[SupportedBy("IOS")]
	public class ActivateExtraDomainsEventParams : IEventParams
	{
		/// <summary>
		/// Domain names that need activation
		/// </summary>
		public string[] Domains { get; set; }
	}
}
