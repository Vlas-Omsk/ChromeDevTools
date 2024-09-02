using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Sets the new stylesheet text.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetStyleSheetTextCommandResult : ICommandResult
	{
		/// <summary>
		/// URL of source map associated with script (if any).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SourceMapURL { get; set; }
	}
}
