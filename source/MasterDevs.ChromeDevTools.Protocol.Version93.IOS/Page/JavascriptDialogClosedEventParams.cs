using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
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
