using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// This object identifies a CSS style in a unique way.
	/// </summary>
	[SupportedBy("iOS")]
	public class CSSStyleId
	{
		/// <summary>
		/// Enclosing stylesheet identifier.
		/// </summary>
		public string StyleSheetId { get; set; }
		/// <summary>
		/// The style ordinal within the stylesheet.
		/// </summary>
		public long Ordinal { get; set; }
	}
}
