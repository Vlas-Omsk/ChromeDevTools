using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.LayerTree
{
	[EventName(ProtocolName.LayerTree.LayerPainted)]
	[SupportedBy("Chrome")]
	public class LayerPaintedEventParams : IEventParams
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
