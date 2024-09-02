using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Returns content of the given resource.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetResourceContentCommandResult : ICommandResult
	{
		/// <summary>
		/// Resource content.
		/// </summary>
		public string Content { get; set; }
		/// <summary>
		/// True, if content was served as base64.
		/// </summary>
		public bool Base64Encoded { get; set; }
	}
}
