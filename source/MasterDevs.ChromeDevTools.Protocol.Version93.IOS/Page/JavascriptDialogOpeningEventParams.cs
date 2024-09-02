using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Fired when a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload) is about to open.
	/// </summary>
	[EventName(ProtocolName.Page.JavascriptDialogOpening)]
	[SupportedBy("IOS")]
	public class JavascriptDialogOpeningEventParams : IEventParams
	{
		/// <summary>
		/// Message that will be displayed by the dialog.
		/// </summary>
		public string Message { get; set; }
	}
}
