using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Set default font sizes.
	/// </summary>
	[Command(ProtocolName.Page.SetFontSizes)]
	[SupportedBy("Chrome")]
	public class SetFontSizesCommand: IProtocolCommand<SetFontSizesCommandResponse>
	{
		/// <summary>
		/// Specifies font sizes to set. If a font size is not specified, it won't be changed.
		/// </summary>
		public FontSizes FontSizes { get; set; }
	}
}
