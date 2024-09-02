using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Network
{
	/// <summary>
	/// Returns content served for the given request.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetResponseBodyCommandParams: ICommandParams<GetResponseBodyCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.GetResponseBody;
		/// <summary>
		/// Identifier of the network request to get content for.
		/// </summary>
		public string RequestId { get; set; }
	}
}
