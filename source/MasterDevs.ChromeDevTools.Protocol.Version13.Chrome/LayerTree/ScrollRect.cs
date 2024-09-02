using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.LayerTree
{
	/// <summary>
	/// Rectangle where scrolling happens on the main thread.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ScrollRect
	{
		/// <summary>
		/// Rectangle itself.
		/// </summary>
		public DOM.Rect Rect { get; set; }
		/// <summary>
		/// Reason for rectangle to force scrolling on the main thread
		/// </summary>
		public string Type { get; set; }
	}
}
