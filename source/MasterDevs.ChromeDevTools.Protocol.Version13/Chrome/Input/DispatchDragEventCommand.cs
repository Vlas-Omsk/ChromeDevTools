using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	/// Dispatches a drag event into the page.
	/// </summary>
	[Command(ProtocolName.Input.DispatchDragEvent)]
	[SupportedBy("Chrome")]
	public class DispatchDragEventCommand: IProtocolCommand<DispatchDragEventCommandResponse>
	{
		/// <summary>
		/// Type of the drag event.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// X coordinate of the event relative to the main frame's viewport in CSS pixels.
		/// </summary>
		public double X { get; set; }
		/// <summary>
		/// Y coordinate of the event relative to the main frame's viewport in CSS pixels. 0 refers to
		/// the top of the viewport and Y increases as it proceeds towards the bottom of the viewport.
		/// </summary>
		public double Y { get; set; }
		/// <summary>
		/// Data
		/// </summary>
		public DragData Data { get; set; }
		/// <summary>
		/// Bit field representing pressed modifier keys. Alt=1, Ctrl=2, Meta/Command=4, Shift=8
		/// (default: 0).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Modifiers { get; set; }
	}
}
