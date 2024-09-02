using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular CSP violations.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetBreakOnCSPViolationCommandParams: ICommandParams<SetBreakOnCSPViolationCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOMDebugger.SetBreakOnCSPViolation;
		/// <summary>
		/// CSP Violations to stop upon.
		/// </summary>
		public string[] ViolationTypes { get; set; }
	}
}
