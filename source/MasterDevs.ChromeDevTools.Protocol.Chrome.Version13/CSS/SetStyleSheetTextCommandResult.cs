using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CSS
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
