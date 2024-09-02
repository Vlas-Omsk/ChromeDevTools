using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Fired when the JavaScript is enabled/disabled on the page
	/// </summary>
	[EventName(ProtocolName.Page.ScriptsEnabled)]
	[SupportedBy("IOS")]
	public class ScriptsEnabledEventParams : IEventParams
	{
		/// <summary>
		/// Whether script execution is enabled or disabled on the page.
		/// </summary>
		public bool IsEnabled { get; set; }
	}
}
