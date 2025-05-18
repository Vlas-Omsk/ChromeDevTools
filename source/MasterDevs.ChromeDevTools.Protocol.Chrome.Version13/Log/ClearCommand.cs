using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Log
{
	/// <summary>
	/// Clears the log.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ClearCommand: ICommand<ClearCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Log.Clear;
	}
}
