using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Set default font sizes.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetFontSizesCommandParams: ICommandParams<SetFontSizesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.SetFontSizes;
		/// <summary>
		/// Specifies font sizes to set. If a font size is not specified, it won't be changed.
		/// </summary>
		public FontSizes FontSizes { get; set; }
	}
}
