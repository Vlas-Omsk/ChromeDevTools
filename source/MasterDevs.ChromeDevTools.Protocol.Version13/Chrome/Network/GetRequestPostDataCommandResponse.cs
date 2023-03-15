using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Returns post data sent with the request. Returns an error when no data was sent with the request.
	/// </summary>
	[CommandResponse(ProtocolName.Network.GetRequestPostData)]
	[SupportedBy("Chrome")]
	public class GetRequestPostDataCommandResponse
	{
		/// <summary>
		/// Request body string, omitting files from multipart requests
		/// </summary>
		public string PostData { get; set; }
	}
}
