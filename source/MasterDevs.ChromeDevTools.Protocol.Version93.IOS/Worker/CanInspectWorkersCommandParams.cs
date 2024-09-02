using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Worker
{
	/// <summary>
	/// Tells whether browser supports workers inspection.
	/// </summary>

	[SupportedBy("IOS")]
	public class CanInspectWorkersCommandParams: ICommandParams<CanInspectWorkersCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Worker.CanInspectWorkers;
	}
}
