using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Fetch
{
	/// <summary>
	/// Causes the request to fail with specified reason.
	/// </summary>

	[SupportedBy("Chrome")]
	public class FailRequestCommandParams: ICommandParams<FailRequestCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Fetch.FailRequest;
		/// <summary>
		/// An id the client received in requestPaused event.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Causes the request to fail with the given reason.
		/// </summary>
		public string ErrorReason { get; set; }
	}
}
