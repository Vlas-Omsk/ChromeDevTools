using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	/// <summary>
	/// Returns metainfo entries for all known stylesheets.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetAllStyleSheetsCommandResult : ICommandResult
	{
		/// <summary>
		/// Descriptor entries for all available stylesheets.
		/// </summary>
		public CSSStyleSheetHeader[] Headers { get; set; }
	}
}
