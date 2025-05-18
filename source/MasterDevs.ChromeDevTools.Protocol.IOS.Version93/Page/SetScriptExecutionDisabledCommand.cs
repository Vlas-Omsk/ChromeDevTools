using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Page
{
	/// <summary>
	/// Switches script execution in the page.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetScriptExecutionDisabledCommand: ICommand<SetScriptExecutionDisabledCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.SetScriptExecutionDisabled;
		/// <summary>
		/// Whether script execution should be disabled in the page.
		/// </summary>
		public bool Value { get; set; }
	}
}
