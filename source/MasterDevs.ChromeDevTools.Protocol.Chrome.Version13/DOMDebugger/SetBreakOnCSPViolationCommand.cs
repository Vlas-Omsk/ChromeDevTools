using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular CSP violations.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetBreakOnCSPViolationCommand: ICommand<SetBreakOnCSPViolationCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOMDebugger.SetBreakOnCSPViolation;
		/// <summary>
		/// CSP Violations to stop upon.
		/// </summary>
		public string[] ViolationTypes { get; set; }
	}
}
