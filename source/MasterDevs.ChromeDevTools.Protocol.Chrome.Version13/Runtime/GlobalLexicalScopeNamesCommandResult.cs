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
	public class GlobalLexicalScopeNamesCommandResult : ICommandResult
	{
		/// <summary>
		/// Names
		/// </summary>
		public string[] Names { get; set; }
	}
}
