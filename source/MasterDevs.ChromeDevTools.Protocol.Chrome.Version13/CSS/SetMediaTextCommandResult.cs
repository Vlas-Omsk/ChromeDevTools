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
	public class SetMediaTextCommandResult : ICommandResult
	{
		/// <summary>
		/// The resulting CSS media rule after modification.
		/// </summary>
		public CSSMedia Media { get; set; }
	}
}
