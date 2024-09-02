using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
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
