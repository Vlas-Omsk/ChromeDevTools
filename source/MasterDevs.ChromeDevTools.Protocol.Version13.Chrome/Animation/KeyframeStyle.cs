using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Animation
{
	/// <summary>
	/// Keyframe Style
	/// </summary>
	[SupportedBy("Chrome")]
	public class KeyframeStyle
	{
		/// <summary>
		/// Keyframe's time offset.
		/// </summary>
		public string Offset { get; set; }
		/// <summary>
		/// `AnimationEffect`'s timing function.
		/// </summary>
		public string Easing { get; set; }
	}
}
