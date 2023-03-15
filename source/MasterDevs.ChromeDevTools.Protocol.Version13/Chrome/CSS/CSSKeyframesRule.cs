using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// CSS keyframes rule representation.
	/// </summary>
	[SupportedBy("Chrome")]
	public class CSSKeyframesRule
	{
		/// <summary>
		/// Animation name.
		/// </summary>
		public Value AnimationName { get; set; }
		/// <summary>
		/// List of keyframes.
		/// </summary>
		public CSSKeyframeRule[] Keyframes { get; set; }
	}
}
