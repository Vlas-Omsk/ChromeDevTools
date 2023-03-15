using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// CSS rule collection for a single pseudo style.
	/// </summary>
	[SupportedBy("Chrome")]
	public class PseudoElementMatches
	{
		/// <summary>
		/// Pseudo element type.
		/// </summary>
		public DOM.PseudoType PseudoType { get; set; }
		/// <summary>
		/// Pseudo element custom ident.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PseudoIdentifier { get; set; }
		/// <summary>
		/// Matches of CSS rules applicable to the pseudo style.
		/// </summary>
		public RuleMatch[] Matches { get; set; }
	}
}
