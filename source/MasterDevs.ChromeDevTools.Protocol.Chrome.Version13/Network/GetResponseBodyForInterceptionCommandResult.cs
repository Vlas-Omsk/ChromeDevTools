using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
{
	/// <summary>
	/// Returns content served for the given currently intercepted request.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetResponseBodyForInterceptionCommandResult : ICommandResult
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
