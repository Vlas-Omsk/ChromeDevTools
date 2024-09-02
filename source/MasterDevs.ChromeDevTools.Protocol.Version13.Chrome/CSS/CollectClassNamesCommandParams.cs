using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Returns all class names from specified stylesheet.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CollectClassNamesCommandParams: ICommandParams<CollectClassNamesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.CollectClassNames;
		/// <summary>
		/// StyleSheetId
		/// </summary>
		public string StyleSheetId { get; set; }
	}
}
