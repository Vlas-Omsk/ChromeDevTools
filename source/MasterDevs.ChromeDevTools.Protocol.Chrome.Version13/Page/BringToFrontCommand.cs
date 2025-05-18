using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Brings page to front (activates tab).
	/// </summary>

	[SupportedBy("Chrome")]
	public class BringToFrontCommand: ICommand<BringToFrontCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.BringToFront;
	}
}
