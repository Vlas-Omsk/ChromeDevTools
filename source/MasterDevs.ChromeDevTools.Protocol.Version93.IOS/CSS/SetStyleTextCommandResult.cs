using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	/// <summary>
	/// Sets the new <code>text</code> for the respective style.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetStyleTextCommandResult : ICommandResult
	{
		/// <summary>
		/// The resulting style after the text modification.
		/// </summary>
		public CSSStyle Style { get; set; }
	}
}
