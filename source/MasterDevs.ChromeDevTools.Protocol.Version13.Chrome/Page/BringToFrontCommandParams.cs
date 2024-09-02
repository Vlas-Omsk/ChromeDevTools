using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Brings page to front (activates tab).
	/// </summary>

	[SupportedBy("Chrome")]
	public class BringToFrontCommandParams: ICommandParams<BringToFrontCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.BringToFront;
	}
}
