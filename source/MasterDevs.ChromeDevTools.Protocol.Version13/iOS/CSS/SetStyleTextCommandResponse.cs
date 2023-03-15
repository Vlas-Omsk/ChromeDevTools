using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Sets the new <code>text</code> for the respective style.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.SetStyleText)]
	[SupportedBy("iOS")]
	public class SetStyleTextCommandResponse
	{
		/// <summary>
		/// The resulting style after the text modification.
		/// </summary>
		public CSSStyle Style { get; set; }
	}
}
