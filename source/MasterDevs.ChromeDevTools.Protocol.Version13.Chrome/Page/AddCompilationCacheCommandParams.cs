using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Seeds compilation cache for given url. Compilation cache does not survive
	/// cross-process navigation.
	/// </summary>

	[SupportedBy("Chrome")]
	public class AddCompilationCacheCommandParams: ICommandParams<AddCompilationCacheCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.AddCompilationCache;
		/// <summary>
		/// Url
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Base64-encoded data (Encoded as a base64 string when passed over JSON)
		/// </summary>
		public string Data { get; set; }
	}
}
