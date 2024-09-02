using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Log
{
	/// <summary>
	/// Log entry.
	/// </summary>
	[SupportedBy("Chrome")]
	public class LogEntry
	{
		/// <summary>
		/// Log entry source.
		/// </summary>
		public string Source { get; set; }
		/// <summary>
		/// Log entry severity.
		/// </summary>
		public string Level { get; set; }
		/// <summary>
		/// Logged text.
		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// Category
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Category { get; set; }
		/// <summary>
		/// Timestamp when this entry was added.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// URL of the resource if known.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Url { get; set; }
		/// <summary>
		/// Line number in the resource.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? LineNumber { get; set; }
		/// <summary>
		/// JavaScript stack trace.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.StackTrace StackTrace { get; set; }
		/// <summary>
		/// Identifier of the network request associated with this entry.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string NetworkRequestId { get; set; }
		/// <summary>
		/// Identifier of the worker associated with this entry.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string WorkerId { get; set; }
		/// <summary>
		/// Call arguments.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.RemoteObject[] Args { get; set; }
	}
}
