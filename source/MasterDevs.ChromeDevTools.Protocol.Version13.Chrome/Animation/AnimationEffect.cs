using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Animation
{
	/// <summary>
	/// AnimationEffect instance
	/// </summary>
	[SupportedBy("Chrome")]
	public class AnimationEffect
	{
		/// <summary>
		/// `AnimationEffect`'s delay.
		/// </summary>
		public double Delay { get; set; }
		/// <summary>
		/// `AnimationEffect`'s end delay.
		/// </summary>
		public double EndDelay { get; set; }
		/// <summary>
		/// `AnimationEffect`'s iteration start.
		/// </summary>
		public double IterationStart { get; set; }
		/// <summary>
		/// `AnimationEffect`'s iterations.
		/// </summary>
		public double Iterations { get; set; }
		/// <summary>
		/// `AnimationEffect`'s iteration duration.
		/// </summary>
		public double Duration { get; set; }
		/// <summary>
		/// `AnimationEffect`'s playback direction.
		/// </summary>
		public string Direction { get; set; }
		/// <summary>
		/// `AnimationEffect`'s fill mode.
		/// </summary>
		public string Fill { get; set; }
		/// <summary>
		/// `AnimationEffect`'s target node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? BackendNodeId { get; set; }
		/// <summary>
		/// `AnimationEffect`'s keyframes.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public KeyframesRule KeyframesRule { get; set; }
		/// <summary>
		/// `AnimationEffect`'s timing function.
		/// </summary>
		public string Easing { get; set; }
	}
}
