using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Memory
{

	[SupportedBy("Chrome")]
	public class PrepareForLeakDetectionCommandParams: ICommandParams<PrepareForLeakDetectionCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Memory.PrepareForLeakDetection;
	}
}