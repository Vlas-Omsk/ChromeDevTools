using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Modifies the expression of a scope at-rule.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetScopeTextCommandResult : ICommandResult
	{
		/// <summary>
		/// The resulting CSS Scope rule after modification.
		/// </summary>
		public CSSScope Scope { get; set; }
	}
}
