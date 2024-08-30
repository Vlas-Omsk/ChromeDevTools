using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular CSP violations.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.SetBreakOnCSPViolation)]
	[SupportedBy("Chrome")]
	public class SetBreakOnCSPViolationCommand: ICommandParams<SetBreakOnCSPViolationCommandResponse>
	{
		/// <summary>
		/// CSP Violations to stop upon.
		/// </summary>
		public string[] ViolationTypes { get; set; }
	}
}
