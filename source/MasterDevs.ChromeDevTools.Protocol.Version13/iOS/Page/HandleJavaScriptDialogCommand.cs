using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Accepts or dismisses a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload).
	/// </summary>
	[Command(ProtocolName.Page.HandleJavaScriptDialog)]
	[SupportedBy("iOS")]
	public class HandleJavaScriptDialogCommand: IProtocolCommand<HandleJavaScriptDialogCommandResponse>
	{
		/// <summary>
		/// Whether to accept or dismiss the dialog.
		/// </summary>
		public bool Accept { get; set; }
		/// <summary>
		/// The text to enter into the dialog prompt before accepting. Used only if this is a prompt dialog.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PromptText { get; set; }
	}
}
