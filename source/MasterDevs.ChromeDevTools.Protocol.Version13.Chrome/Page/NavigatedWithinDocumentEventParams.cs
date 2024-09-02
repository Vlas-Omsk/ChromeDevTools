using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Fired when same-document navigation happens, e.g. due to history API usage or anchor navigation.
	/// </summary>
	[EventName(ProtocolName.Page.NavigatedWithinDocument)]
	[SupportedBy("Chrome")]
	public class NavigatedWithinDocumentEventParams : IEventParams
	{
		/// <summary>
		/// Id of the frame.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Frame's new url.
		/// </summary>
		public string Url { get; set; }
	}
}
