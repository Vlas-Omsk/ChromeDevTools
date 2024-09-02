using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Fired when `Element`'s inline style is modified via a CSS property modification.
	/// </summary>
	[EventName(ProtocolName.DOM.InlineStyleInvalidated)]
	[SupportedBy("Chrome")]
	public class InlineStyleInvalidatedEventParams : IEventParams
	{
		/// <summary>
		/// Ids of the nodes for which the inline styles have been invalidated.
		/// </summary>
		public long[] NodeIds { get; set; }
	}
}
