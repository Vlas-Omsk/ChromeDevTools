using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Debugger
{
	/// <summary>
	/// Activates / deactivates all breakpoints on the page.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetBreakpointsActiveCommand: ICommand<SetBreakpointsActiveCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.SetBreakpointsActive;
		/// <summary>
		/// New value for breakpoints active state.
		/// </summary>
		public bool Active { get; set; }
	}
}
