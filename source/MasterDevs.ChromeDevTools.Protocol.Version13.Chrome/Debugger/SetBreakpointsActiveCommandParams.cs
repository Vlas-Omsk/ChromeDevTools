using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	/// <summary>
	/// Activates / deactivates all breakpoints on the page.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetBreakpointsActiveCommandParams: ICommandParams<SetBreakpointsActiveCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.SetBreakpointsActive;
		/// <summary>
		/// New value for breakpoints active state.
		/// </summary>
		public bool Active { get; set; }
	}
}
