using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Issued for every compilation cache generated. Is only available
	/// if Page.setGenerateCompilationCache is enabled.
	/// </summary>
	[EventName(ProtocolName.Page.CompilationCacheProduced)]
	[SupportedBy("Chrome")]
	public class CompilationCacheProducedEventParams : IEventParams
	{
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
