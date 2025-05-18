using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Runtime
{
	/// <summary>
	/// Returns all let, const and class variables from global scope.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GlobalLexicalScopeNamesCommand: ICommand<GlobalLexicalScopeNamesCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.GlobalLexicalScopeNames;
		/// <summary>
		/// Specifies in which execution context to lookup global scope variables.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ExecutionContextId { get; set; }
	}
}
