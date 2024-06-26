using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.LayerTree
{
	[Event(ProtocolName.LayerTree.LayerPainted)]
	[SupportedBy("Chrome")]
	public class LayerPaintedEvent
	{
		/// <summary>
		/// The id of the painted layer.
		/// </summary>
		public string LayerId { get; set; }
		/// <summary>
		/// Clip rectangle.
		/// </summary>
		public DOM.Rect Clip { get; set; }
	}
}
