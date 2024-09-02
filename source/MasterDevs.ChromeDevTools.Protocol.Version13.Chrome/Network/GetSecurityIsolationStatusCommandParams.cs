using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Returns information about the COEP/COOP isolation status.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetSecurityIsolationStatusCommandParams: ICommandParams<GetSecurityIsolationStatusCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.GetSecurityIsolationStatus;
		/// <summary>
		/// If no frameId is provided, the status of the target is provided.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FrameId { get; set; }
	}
}
