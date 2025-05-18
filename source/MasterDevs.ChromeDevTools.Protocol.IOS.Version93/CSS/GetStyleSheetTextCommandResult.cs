using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.CSS
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
