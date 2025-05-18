using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Fetch
{
	/// <summary>
	/// Returns a handle to the stream representing the response body.
	/// The request must be paused in the HeadersReceived stage.
	/// Note that after this command the request can't be continued
	/// as is -- client either needs to cancel it or to provide the
	/// response body.
	/// The stream only supports sequential read, IO.read will fail if the position
	/// is specified.
	/// This method is mutually exclusive with getResponseBody.
	/// Calling other methods that affect the request or disabling fetch
	/// domain before body is received results in an undefined behavior.
	/// </summary>

	[SupportedBy("Chrome")]
	public class TakeResponseBodyAsStreamCommand: ICommand<TakeResponseBodyAsStreamCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Fetch.TakeResponseBodyAsStream;
		/// <summary>
		/// RequestId
		/// </summary>
		public string RequestId { get; set; }
	}
}
