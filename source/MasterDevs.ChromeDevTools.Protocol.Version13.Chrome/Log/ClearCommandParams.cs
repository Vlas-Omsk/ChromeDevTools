using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Log
{
	/// <summary>
	/// Clears the log.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ClearCommandParams: ICommandParams<ClearCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Log.Clear;
	}
}
