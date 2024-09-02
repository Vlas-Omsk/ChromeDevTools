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
	public class SetStyleTextCommandParams: ICommandParams<SetStyleTextCommandResult>
	{
		public string MethodName { get; } = ProtocolName.CSS.SetStyleText;
		/// <summary>
		/// StyleId
		/// </summary>
		public CSSStyleId StyleId { get; set; }
		/// <summary>
		/// Text
		/// </summary>
		public string Text { get; set; }
	}
}
