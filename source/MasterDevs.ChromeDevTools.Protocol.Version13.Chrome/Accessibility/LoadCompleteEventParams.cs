using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Accessibility
{
	/// <summary>
	/// The loadComplete event mirrors the load complete event sent by the browser to assistive
	/// technology when the web page has finished loading.
	/// </summary>
	[EventName(ProtocolName.Accessibility.LoadComplete)]
	[SupportedBy("Chrome")]
	public class LoadCompleteEventParams : IEventParams
	{
		/// <summary>
		/// New document root node.
		/// </summary>
		public AXNode Root { get; set; }
	}
}
