using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Emitted only when `page.interceptFileChooser` is enabled.
	/// </summary>
	[EventName(ProtocolName.Page.FileChooserOpened)]
	[SupportedBy("Chrome")]
	public class FileChooserOpenedEventParams : IEventParams
	{
		/// <summary>
		/// Id of the frame containing input node.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Input mode.
		/// </summary>
		public string Mode { get; set; }
		/// <summary>
		/// Input node id. Only present for file choosers opened via an <input type="file"> element.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? BackendNodeId { get; set; }
	}
}
