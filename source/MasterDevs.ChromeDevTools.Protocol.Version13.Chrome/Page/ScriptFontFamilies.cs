using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Font families collection for a script.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ScriptFontFamilies
	{
		/// <summary>
		/// Name of the script which these font families are defined for.
		/// </summary>
		public string Script { get; set; }
		/// <summary>
		/// Generic font families collection for the script.
		/// </summary>
		public FontFamilies FontFamilies { get; set; }
	}
}
