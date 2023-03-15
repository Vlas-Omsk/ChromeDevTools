using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Returns content served for the given request.
	/// </summary>
	[CommandResponse(ProtocolName.Network.GetResponseBody)]
	[SupportedBy("iOS")]
	public class GetResponseBodyCommandResponse
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
