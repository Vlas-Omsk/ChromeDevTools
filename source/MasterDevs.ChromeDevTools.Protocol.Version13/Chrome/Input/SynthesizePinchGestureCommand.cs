using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	/// Synthesizes a pinch gesture over a time period by issuing appropriate touch events.
	/// </summary>
	[Command(ProtocolName.Input.SynthesizePinchGesture)]
	[SupportedBy("Chrome")]
	public class SynthesizePinchGestureCommand: ICommandParams<SynthesizePinchGestureCommandResponse>
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
		/// Relative scale factor after zooming (>1.0 zooms in, <1.0 zooms out).
		/// </summary>
		public double ScaleFactor { get; set; }
		/// <summary>
		/// Relative pointer speed in pixels per second (default: 800).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? RelativeSpeed { get; set; }
		/// <summary>
		/// Which type of input events to be generated (default: 'default', which queries the platform
		/// for the preferred input type).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string GestureSourceType { get; set; }
	}
}
