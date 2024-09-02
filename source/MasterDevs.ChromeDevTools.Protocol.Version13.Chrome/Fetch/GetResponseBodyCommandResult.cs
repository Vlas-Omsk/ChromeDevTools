using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Fetch
{
	/// <summary>
	/// Causes the body of the response to be received from the server and
	/// returned as a single string. May only be issued for a request that
	/// is paused in the Response stage and is mutually exclusive with
	/// takeResponseBodyForInterceptionAsStream. Calling other methods that
	/// affect the request or disabling fetch domain before body is received
	/// results in an undefined behavior.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetResponseBodyCommandResult : ICommandResult
	{
		/// <summary>
		/// Response body.
		/// </summary>
		public string Body { get; set; }
		/// <summary>
		/// True, if content was sent as base64.
		/// </summary>
		public bool Base64Encoded { get; set; }
	}
}
