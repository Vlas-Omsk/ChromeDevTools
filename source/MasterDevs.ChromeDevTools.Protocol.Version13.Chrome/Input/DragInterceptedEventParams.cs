using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Input
{
	/// <summary>
	/// Emitted only when `Input.setInterceptDrags` is enabled. Use this data with `Input.dispatchDragEvent` to
	/// restore normal drag and drop behavior.
	/// </summary>
	[EventName(ProtocolName.Input.DragIntercepted)]
	[SupportedBy("Chrome")]
	public class DragInterceptedEventParams : IEventParams
	{
		/// <summary>
		/// Data
		/// </summary>
		public DragData Data { get; set; }
	}
}
