using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.CSS
{
	/// <summary>
	/// This object identifies a CSS rule in a unique way.
	/// </summary>
	[SupportedBy("IOS")]
	public class CSSRuleId
	{
		/// <summary>
		/// Enclosing stylesheet identifier.
		/// </summary>
		public string StyleSheetId { get; set; }
		/// <summary>
		/// The rule ordinal within the stylesheet.
		/// </summary>
		public long Ordinal { get; set; }
	}
}
