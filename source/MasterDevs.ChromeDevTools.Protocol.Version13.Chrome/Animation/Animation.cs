using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Animation
{
	/// <summary>
	/// Animation instance.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Animation
	{
		/// <summary>
		/// `Animation`'s id.
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// `Animation`'s name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// `Animation`'s internal paused state.
		/// </summary>
		public bool PausedState { get; set; }
		/// <summary>
		/// `Animation`'s play state.
		/// </summary>
		public string PlayState { get; set; }
		/// <summary>
		/// `Animation`'s playback rate.
		/// </summary>
		public double PlaybackRate { get; set; }
		/// <summary>
		/// `Animation`'s start time.
		/// </summary>
		public double StartTime { get; set; }
		/// <summary>
		/// `Animation`'s current time.
		/// </summary>
		public double CurrentTime { get; set; }
		/// <summary>
		/// Animation type of `Animation`.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// `Animation`'s source animation node.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AnimationEffect Source { get; set; }
		/// <summary>
		/// A unique ID for `Animation` representing the sources that triggered this CSS
		/// animation/transition.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string CssId { get; set; }
	}
}
