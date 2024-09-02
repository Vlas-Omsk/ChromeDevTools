using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.IndexedDB
{
	/// <summary>
	/// Disables events from backend.
	/// </summary>

	[SupportedBy("Chrome")]
	public class DisableCommandParams: ICommandParams<DisableCommandResult>
	{
		public string MethodName { get; } = ProtocolName.IndexedDB.Disable;
	}
}
