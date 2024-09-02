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
	public class HandleJavaScriptDialogCommandResult : ICommandResult
	{
	}
}
