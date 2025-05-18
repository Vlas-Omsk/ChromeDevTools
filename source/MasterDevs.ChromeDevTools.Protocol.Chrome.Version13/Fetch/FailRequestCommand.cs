using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Fetch
{
	/// <summary>
	/// Causes the request to fail with specified reason.
	/// </summary>

	[SupportedBy("Chrome")]
	public class FailRequestCommand: ICommand<FailRequestCommandResult>
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
