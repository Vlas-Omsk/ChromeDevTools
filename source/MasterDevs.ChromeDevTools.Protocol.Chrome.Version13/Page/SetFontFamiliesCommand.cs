using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Set generic font families.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetFontFamiliesCommand: ICommand<SetFontFamiliesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.SetFontFamilies;
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
