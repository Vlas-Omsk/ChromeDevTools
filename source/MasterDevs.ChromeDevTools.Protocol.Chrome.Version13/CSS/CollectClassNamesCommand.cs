using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CSS
{
	/// <summary>
	/// Returns all class names from specified stylesheet.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CollectClassNamesCommand: ICommand<CollectClassNamesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.CollectClassNames;
		/// <summary>
		/// StyleSheetId
		/// </summary>
		public string StyleSheetId { get; set; }
	}
}
