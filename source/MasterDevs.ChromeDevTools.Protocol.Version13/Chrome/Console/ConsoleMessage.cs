using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Console
{
	/// <summary>
	/// Console message.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ConsoleMessage
	{
		/// <summary>
		/// Message source.
		/// </summary>
		public string Source { get; set; }
		/// <summary>
		/// Message severity.
		/// </summary>
		public string Level { get; set; }
		/// <summary>
		/// Message text.
		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// URL of the message origin.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Url { get; set; }
		/// <summary>
		/// Line number in the resource that generated this message (1-based).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Line { get; set; }
		/// <summary>
		/// Column number in the resource that generated this message (1-based).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Column { get; set; }
	}
}
