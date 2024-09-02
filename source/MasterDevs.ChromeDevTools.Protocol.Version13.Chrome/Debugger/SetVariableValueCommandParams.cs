using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	/// <summary>
	/// Changes value of variable in a callframe. Object-based scopes are not supported and must be
	/// mutated manually.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetVariableValueCommandParams: ICommandParams<SetVariableValueCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.SetVariableValue;
		/// <summary>
		/// 0-based number of scope as was listed in scope chain. Only 'local', 'closure' and 'catch'
		/// scope types are allowed. Other scopes could be manipulated manually.
		/// </summary>
		public long ScopeNumber { get; set; }
		/// <summary>
		/// Variable name.
		/// </summary>
		public string VariableName { get; set; }
		/// <summary>
		/// New variable value.
		/// </summary>
		public Runtime.CallArgument NewValue { get; set; }
		/// <summary>
		/// Id of callframe that holds variable.
		/// </summary>
		public string CallFrameId { get; set; }
	}
}
