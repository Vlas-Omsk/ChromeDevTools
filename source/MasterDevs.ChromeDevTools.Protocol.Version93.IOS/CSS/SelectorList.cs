using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	/// <summary>
	/// Selector list data.
	/// </summary>
	[SupportedBy("IOS")]
	public class SelectorList
	{
		/// <summary>
		/// Selectors in the list.
		/// </summary>
		public CSSSelector[] Selectors { get; set; }
		/// <summary>
		/// Rule selector text.
		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// Rule selector range in the underlying resource (if available).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SourceRange Range { get; set; }
	}
}
