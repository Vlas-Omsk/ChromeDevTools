using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Memory
{
	/// <summary>
	/// Retrieve native memory allocations profile
	/// collected since browser process startup.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetBrowserSamplingProfileCommandParams: ICommandParams<GetBrowserSamplingProfileCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Memory.GetBrowserSamplingProfile;
	}
}
