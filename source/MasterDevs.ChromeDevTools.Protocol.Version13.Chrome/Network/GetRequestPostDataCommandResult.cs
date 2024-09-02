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
	public class GetRequestPostDataCommandResult : ICommandResult
	{
		/// <summary>
		/// Request body string, omitting files from multipart requests
		/// </summary>
		public string PostData { get; set; }
	}
}
