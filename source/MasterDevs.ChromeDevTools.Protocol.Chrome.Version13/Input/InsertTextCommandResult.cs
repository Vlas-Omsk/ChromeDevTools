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
	public class InsertTextCommandResult : ICommandResult
	{
	}
}
