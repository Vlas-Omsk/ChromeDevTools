using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Modifies the expression of a supports at-rule.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetSupportsTextCommandResult : ICommandResult
	{
		/// <summary>
		/// The resulting CSS Supports rule after modification.
		/// </summary>
		public CSSSupports Supports { get; set; }
	}
}
