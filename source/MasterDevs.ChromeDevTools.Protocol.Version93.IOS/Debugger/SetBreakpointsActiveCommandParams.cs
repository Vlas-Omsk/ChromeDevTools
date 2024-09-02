using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Debugger
{
	/// <summary>
	/// Activates / deactivates all breakpoints on the page.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetBreakpointsActiveCommandParams: ICommandParams<SetBreakpointsActiveCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.SetBreakpointsActive;
		/// <summary>
		/// New value for breakpoints active state.
		/// </summary>
		public bool Active { get; set; }
	}
}
