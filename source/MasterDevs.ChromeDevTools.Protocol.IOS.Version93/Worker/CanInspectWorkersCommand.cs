using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Worker
{
	/// <summary>
	/// Tells whether browser supports workers inspection.
	/// </summary>

	[SupportedBy("IOS")]
	public class CanInspectWorkersCommand: ICommand<CanInspectWorkersCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Worker.CanInspectWorkers;
	}
}
