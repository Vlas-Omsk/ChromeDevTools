using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	/// <summary>
	/// Returns the current textual content and the URL for a stylesheet.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetStyleSheetTextCommandResult : ICommandResult
	{
		/// <summary>
		/// The stylesheet text.
		/// </summary>
		public string Text { get; set; }
	}
}
