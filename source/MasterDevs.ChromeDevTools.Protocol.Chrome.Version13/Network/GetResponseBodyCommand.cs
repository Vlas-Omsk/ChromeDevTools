using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
{
	/// <summary>
	/// Returns content served for the given request.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetResponseBodyCommand: ICommand<GetResponseBodyCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.GetResponseBody;
		/// <summary>
		/// Identifier of the network request to get content for.
		/// </summary>
		public string RequestId { get; set; }
	}
}
