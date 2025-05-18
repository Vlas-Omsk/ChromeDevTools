using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Set default font sizes.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetFontSizesCommand: ICommand<SetFontSizesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.SetFontSizes;
		/// <summary>
		/// Specifies font sizes to set. If a font size is not specified, it won't be changed.
		/// </summary>
		public FontSizes FontSizes { get; set; }
	}
}
