using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Security
{
	/// <summary>
	/// The security state of the page changed.
	/// </summary>
	[EventName(ProtocolName.Security.VisibleSecurityStateChanged)]
	[SupportedBy("Chrome")]
	public class VisibleSecurityStateChangedEventParams : IEventParams
	{
		/// <summary>
		/// Security state information about the page.
		/// </summary>
		public VisibleSecurityState VisibleSecurityState { get; set; }
	}
}
