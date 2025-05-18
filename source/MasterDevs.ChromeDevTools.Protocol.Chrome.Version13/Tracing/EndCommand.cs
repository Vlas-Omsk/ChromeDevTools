using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Tracing
{
	/// <summary>
	/// Stop trace events collection.
	/// </summary>

	[SupportedBy("Chrome")]
	public class EndCommand: ICommand<EndCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Tracing.End;
	}
}
