using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Keyframes Rule
	/// </summary>
	[SupportedBy("Chrome")]
	public class KeyframesRule
	{
		/// <summary>
		/// CSS keyframed animation's name.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Name { get; set; }
		/// <summary>
		/// List of animation keyframes.
		/// </summary>
		public KeyframeStyle[] Keyframes { get; set; }
	}
}
