using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.IndexedDB
{
	/// <summary>
	/// Enables events from backend.
	/// </summary>

	[SupportedBy("IOS")]
	public class EnableCommandParams: ICommandParams<EnableCommandResult>
	{
		public string MethodName { get; } = ProtocolName.IndexedDB.Enable;
	}
}
