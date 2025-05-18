using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CSS
{
	/// <summary>
	/// Inherited pseudo element matches from pseudos of an ancestor node.
	/// </summary>
	[SupportedBy("Chrome")]
	public class InheritedPseudoElementMatches
	{
		/// <summary>
		/// Matches of pseudo styles from the pseudos of an ancestor node.
		/// </summary>
		public PseudoElementMatches[] PseudoElements { get; set; }
	}
}
