using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.CSS
{
	/// <summary>
	/// Modifies the rule selector.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetRuleSelectorCommandResult : ICommandResult
	{
		/// <summary>
		/// The resulting selector list after modification.
		/// </summary>
		public SelectorList SelectorList { get; set; }
	}
}
