using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Applies specified style edits one after another in the given order.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetStyleTextsCommandResult : ICommandResult
	{
		/// <summary>
		/// The resulting styles after modification.
		/// </summary>
		public CSSStyle[] Styles { get; set; }
	}
}
