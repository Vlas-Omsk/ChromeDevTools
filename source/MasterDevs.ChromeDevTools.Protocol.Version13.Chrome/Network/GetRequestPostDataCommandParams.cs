using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Returns post data sent with the request. Returns an error when no data was sent with the request.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetRequestPostDataCommandParams: ICommandParams<GetRequestPostDataCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.GetRequestPostData;
		/// <summary>
		/// Identifier of the network request to get content for.
		/// </summary>
		public string RequestId { get; set; }
	}
}
