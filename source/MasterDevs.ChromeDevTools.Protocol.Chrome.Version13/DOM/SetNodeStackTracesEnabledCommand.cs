using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
{
	/// <summary>
	/// Sets if stack traces should be captured for Nodes. See `Node.getNodeStackTraces`. Default is disabled.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetNodeStackTracesEnabledCommand: ICommand<SetNodeStackTracesEnabledCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.SetNodeStackTracesEnabled;
		/// <summary>
		/// Enable or disable.
		/// </summary>
		public bool Enable { get; set; }
	}
}
