using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	/// Emulates touch event from the mouse event parameters.
	/// </summary>
	[Command(ProtocolName.Input.EmulateTouchFromMouseEvent)]
	[SupportedBy("Chrome")]
	public class EmulateTouchFromMouseEventCommand: ICommandParams<EmulateTouchFromMouseEventCommandResponse>
	{
		/// <summary>
		/// Type of the mouse event.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// X coordinate of the mouse pointer in DIP.
		/// </summary>
		public long X { get; set; }
		/// <summary>
		/// Y coordinate of the mouse pointer in DIP.
		/// </summary>
		public long Y { get; set; }
		/// <summary>
		/// Mouse button. Only "none", "left", "right" are supported.
		/// </summary>
		public string Button { get; set; }
		/// <summary>
		/// Time at which the event occurred (default: current time).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Timestamp { get; set; }
		/// <summary>
		/// X delta in DIP for mouse wheel event (default: 0).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double DeltaX { get; set; }
		/// <summary>
		/// Y delta in DIP for mouse wheel event (default: 0).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double DeltaY { get; set; }
		/// <summary>
		/// Bit field representing pressed modifier keys. Alt=1, Ctrl=2, Meta/Command=4, Shift=8
		/// (default: 0).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Modifiers { get; set; }
		/// <summary>
		/// Number of times the mouse button was clicked (default: 0).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ClickCount { get; set; }
	}
}
