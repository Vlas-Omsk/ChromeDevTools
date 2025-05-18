using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Memory
{
	/// <summary>
	/// Retrieve native memory allocations profile
	/// collected since renderer process startup.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetAllTimeSamplingProfileCommand: ICommand<GetAllTimeSamplingProfileCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Memory.GetAllTimeSamplingProfile;
	}
}
