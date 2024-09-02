using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// This method sends a new XMLHttpRequest which is identical to the original one. The following
	/// parameters should be identical: method, url, async, request body, extra headers, withCredentials
	/// attribute, user, password.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ReplayXHRCommandParams: ICommandParams<ReplayXHRCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.ReplayXHR;
		/// <summary>
		/// Identifier of XHR to replay.
		/// </summary>
		public string RequestId { get; set; }
	}
}
