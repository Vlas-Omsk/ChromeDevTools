using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Memory
{

	[SupportedBy("Chrome")]
	public class GetDOMCountersCommand: ICommand<GetDOMCountersCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Memory.GetDOMCounters;
	}
}
