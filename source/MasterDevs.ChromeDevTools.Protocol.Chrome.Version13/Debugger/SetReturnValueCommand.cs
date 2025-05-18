using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Debugger
{
	/// <summary>
	/// Changes return value in top frame. Available only at return break position.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetReturnValueCommand: ICommand<SetReturnValueCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.SetReturnValue;
		/// <summary>
		/// New return value.
		/// </summary>
		public Runtime.CallArgument NewValue { get; set; }
	}
}
