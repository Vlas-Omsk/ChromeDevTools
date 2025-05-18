using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CSS
{
	/// <summary>
	/// Returns the current textual content for a stylesheet.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetStyleSheetTextCommandResult : ICommandResult
	{
		/// <summary>
		/// The stylesheet text.
		/// </summary>
		public string Text { get; set; }
	}
}
