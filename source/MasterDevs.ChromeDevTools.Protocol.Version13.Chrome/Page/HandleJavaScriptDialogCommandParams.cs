using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Accepts or dismisses a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload).
	/// </summary>

	[SupportedBy("Chrome")]
	public class HandleJavaScriptDialogCommandParams: ICommandParams<HandleJavaScriptDialogCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.HandleJavaScriptDialog;
		/// <summary>
		/// Whether to accept or dismiss the dialog.
		/// </summary>
		public bool Accept { get; set; }
		/// <summary>
		/// The text to enter into the dialog prompt before accepting. Used only if this is a prompt
		/// dialog.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PromptText { get; set; }
	}
}