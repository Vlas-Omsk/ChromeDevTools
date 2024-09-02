using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Memory
{
	/// <summary>
	/// Retrieve native memory allocations profile collected since last
	/// `startSampling` call.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetSamplingProfileCommandParams: ICommandParams<GetSamplingProfileCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Memory.GetSamplingProfile;
	}
}
