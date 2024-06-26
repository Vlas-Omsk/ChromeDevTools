using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	/// Synthesizes a tap gesture over a time period by issuing appropriate touch events.
	/// </summary>
	[Command(ProtocolName.Input.SynthesizeTapGesture)]
	[SupportedBy("Chrome")]
	public class SynthesizeTapGestureCommand: IProtocolCommand<SynthesizeTapGestureCommandResponse>
	{
		/// <summary>
		/// X coordinate of the start of the gesture in CSS pixels.
		/// </summary>
		public double X { get; set; }
		/// <summary>
		/// Y coordinate of the start of the gesture in CSS pixels.
		/// </summary>
		public double Y { get; set; }
		/// <summary>
		/// Duration between touchdown and touchup events in ms (default: 50).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Duration { get; set; }
		/// <summary>
		/// Number of times to perform the tap (e.g. 2 for double tap, default: 1).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? TapCount { get; set; }
		/// <summary>
		/// Which type of input events to be generated (default: 'default', which queries the platform
		/// for the preferred input type).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string GestureSourceType { get; set; }
	}
}
