using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
{
	/// <summary>
	/// Returns post data sent with the request. Returns an error when no data was sent with the request.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetRequestPostDataCommand: ICommand<GetRequestPostDataCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.GetRequestPostData;
		/// <summary>
		/// Identifier of the network request to get content for.
		/// </summary>
		public string RequestId { get; set; }
	}
}
