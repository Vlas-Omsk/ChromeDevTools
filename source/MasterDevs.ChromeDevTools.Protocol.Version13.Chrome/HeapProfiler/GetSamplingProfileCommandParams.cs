using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.HeapProfiler
{

	[SupportedBy("Chrome")]
	public class GetSamplingProfileCommandParams: ICommandParams<GetSamplingProfileCommandResult>
	{
		public string MethodName { get; } = ProtocolName.HeapProfiler.GetSamplingProfile;
	}
}
