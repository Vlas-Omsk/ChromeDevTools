using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Cast
{
	[SupportedBy("Chrome")]
	public class Sink
	{
		/// <summary>
		/// Name
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Id
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Text describing the current session. Present only if there is an active
		/// session on the sink.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Session { get; set; }
	}
}
