using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Inspector
{
	/// <summary>
	/// Sent by the frontend after all initialization messages have been sent.
	/// </summary>

	[SupportedBy("IOS")]
	public class InitializedCommandResult : ICommandResult
	{
	}
}
