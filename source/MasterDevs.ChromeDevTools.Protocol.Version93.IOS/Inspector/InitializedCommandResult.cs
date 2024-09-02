using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Inspector
{
	/// <summary>
	/// Sent by the frontend after all initialization messages have been sent.
	/// </summary>

	[SupportedBy("IOS")]
	public class InitializedCommandResult : ICommandResult
	{
	}
}
