using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Creates a new special "via-inspector" stylesheet in the frame with given `frameId`.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CreateStyleSheetCommandResult : ICommandResult
	{
		/// <summary>
		/// Identifier of the created "via-inspector" stylesheet.
		/// </summary>
		public string StyleSheetId { get; set; }
	}
}
