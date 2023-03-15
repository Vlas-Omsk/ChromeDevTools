using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Set generic font families.
	/// </summary>
	[Command(ProtocolName.Page.SetFontFamilies)]
	[SupportedBy("Chrome")]
	public class SetFontFamiliesCommand: IProtocolCommand<SetFontFamiliesCommandResponse>
	{
		/// <summary>
		/// Specifies font families to set. If a font family is not specified, it won't be changed.
		/// </summary>
		public FontFamilies FontFamilies { get; set; }
		/// <summary>
		/// Specifies font families to set for individual scripts.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ScriptFontFamilies[] ForScripts { get; set; }
	}
}
