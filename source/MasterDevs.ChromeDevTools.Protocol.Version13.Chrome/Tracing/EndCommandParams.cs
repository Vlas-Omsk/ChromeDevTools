using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Tracing
{
	/// <summary>
	/// Stop trace events collection.
	/// </summary>

	[SupportedBy("Chrome")]
	public class EndCommandParams: ICommandParams<EndCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Tracing.End;
	}
}
