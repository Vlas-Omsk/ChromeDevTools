using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Fired when a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload) has been
	/// closed.
	/// </summary>
	[EventName(ProtocolName.Page.JavascriptDialogClosed)]
	[SupportedBy("Chrome")]
	public class JavascriptDialogClosedEventParams : IEventParams
	{
		/// <summary>
		/// Whether dialog was confirmed.
		/// </summary>
		public bool Result { get; set; }
		/// <summary>
		/// User input in case of prompt.
		/// </summary>
		public string UserInput { get; set; }
	}
}
