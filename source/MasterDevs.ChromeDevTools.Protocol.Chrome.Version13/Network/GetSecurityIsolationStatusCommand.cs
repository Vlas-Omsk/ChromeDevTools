using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
{
	/// <summary>
	/// Returns information about the COEP/COOP isolation status.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetSecurityIsolationStatusCommand: ICommand<GetSecurityIsolationStatusCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.GetSecurityIsolationStatus;
		/// <summary>
		/// If no frameId is provided, the status of the target is provided.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FrameId { get; set; }
	}
}
