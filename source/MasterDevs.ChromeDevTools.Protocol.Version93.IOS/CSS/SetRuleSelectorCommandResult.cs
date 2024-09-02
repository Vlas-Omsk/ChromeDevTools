using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	/// <summary>
	/// Modifies the rule selector.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetRuleSelectorCommandResult : ICommandResult
	{
		/// <summary>
		/// The resulting rule after the selector modification.
		/// </summary>
		public CSSRule Rule { get; set; }
	}
}
