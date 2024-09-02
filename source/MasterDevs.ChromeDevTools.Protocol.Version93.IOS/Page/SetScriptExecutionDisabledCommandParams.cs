using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Switches script execution in the page.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetScriptExecutionDisabledCommandParams: ICommandParams<SetScriptExecutionDisabledCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.SetScriptExecutionDisabled;
		/// <summary>
		/// Whether script execution should be disabled in the page.
		/// </summary>
		public bool Value { get; set; }
	}
}
