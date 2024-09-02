using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Gets stack traces associated with a Node. As of now, only provides stack trace for Node creation.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetNodeStackTracesCommandResult : ICommandResult
	{
		/// <summary>
		/// Creation stack trace, if available.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.StackTrace Creation { get; set; }
	}
}
