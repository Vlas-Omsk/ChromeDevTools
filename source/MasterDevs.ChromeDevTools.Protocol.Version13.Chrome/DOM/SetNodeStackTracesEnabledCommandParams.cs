using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Sets if stack traces should be captured for Nodes. See `Node.getNodeStackTraces`. Default is disabled.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetNodeStackTracesEnabledCommandParams: ICommandParams<SetNodeStackTracesEnabledCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.SetNodeStackTracesEnabled;
		/// <summary>
		/// Enable or disable.
		/// </summary>
		public bool Enable { get; set; }
	}
}
