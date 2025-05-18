using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CSS
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
