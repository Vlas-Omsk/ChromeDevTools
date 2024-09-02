using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Enables DOM agent for the given page.
	/// </summary>

	[SupportedBy("Chrome")]
	public class EnableCommandParams: ICommandParams<EnableCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.Enable;
		/// <summary>
		/// Whether to include whitespaces in the children array of returned Nodes.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string IncludeWhitespace { get; set; }
	}
}
