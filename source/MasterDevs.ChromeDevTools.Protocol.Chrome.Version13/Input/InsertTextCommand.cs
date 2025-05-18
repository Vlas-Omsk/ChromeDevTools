using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Input
{
	/// <summary>
	/// This method emulates inserting text that doesn't come from a key press,
	/// for example an emoji keyboard or an IME.
	/// </summary>

	[SupportedBy("Chrome")]
	public class InsertTextCommand: ICommand<InsertTextCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Input.InsertText;
		/// <summary>
		/// The text to insert.
		/// </summary>
		public string Text { get; set; }
	}
}
