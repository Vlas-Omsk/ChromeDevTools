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
	public class SetMediaTextCommandResult : ICommandResult
	{
		/// <summary>
		/// The resulting CSS media rule after modification.
		/// </summary>
		public CSSMedia Media { get; set; }
	}
}
