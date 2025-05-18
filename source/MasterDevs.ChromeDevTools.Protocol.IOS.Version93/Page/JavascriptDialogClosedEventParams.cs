using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Page
{
	/// <summary>
	/// Fired when a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload) has been closed.
	/// </summary>
	[EventName(ProtocolName.Page.JavascriptDialogClosed)]
	[SupportedBy("IOS")]
	public class JavascriptDialogClosedEventParams : IEventParams
	{
	}
}
