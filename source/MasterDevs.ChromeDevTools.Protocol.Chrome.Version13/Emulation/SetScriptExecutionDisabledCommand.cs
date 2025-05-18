using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Emulation
{
	/// <summary>
	/// Switches script execution in the page.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetScriptExecutionDisabledCommand: ICommand<SetScriptExecutionDisabledCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetScriptExecutionDisabled;
		/// <summary>
		/// Whether script execution should be disabled in the page.
		/// </summary>
		public bool Value { get; set; }
	}
}
