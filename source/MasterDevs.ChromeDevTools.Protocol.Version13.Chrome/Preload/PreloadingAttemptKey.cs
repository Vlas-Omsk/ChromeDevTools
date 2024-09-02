using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Preload
{
	/// <summary>
	/// A key that identifies a preloading attempt.
	/// 
	/// The url used is the url specified by the trigger (i.e. the initial URL), and
	/// not the final url that is navigated to. For example, prerendering allows
	/// same-origin main frame navigations during the attempt, but the attempt is
	/// still keyed with the initial URL.
	/// </summary>
	[SupportedBy("Chrome")]
	public class PreloadingAttemptKey
	{
		/// <summary>
		/// LoaderId
		/// </summary>
		public string LoaderId { get; set; }
		/// <summary>
		/// Action
		/// </summary>
		public SpeculationAction Action { get; set; }
		/// <summary>
		/// Url
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// TargetHint
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SpeculationTargetHint TargetHint { get; set; }
	}
}
