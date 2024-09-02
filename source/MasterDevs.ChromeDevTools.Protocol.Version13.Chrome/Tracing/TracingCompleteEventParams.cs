using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Tracing
{
	/// <summary>
	/// Signals that tracing is stopped and there is no trace buffers pending flush, all data were
	/// delivered via dataCollected events.
	/// </summary>
	[EventName(ProtocolName.Tracing.TracingComplete)]
	[SupportedBy("Chrome")]
	public class TracingCompleteEventParams : IEventParams
	{
		/// <summary>
		/// Indicates whether some trace data is known to have been lost, e.g. because the trace ring
		/// buffer wrapped around.
		/// </summary>
		public bool DataLossOccurred { get; set; }
		/// <summary>
		/// A handle of the stream that holds resulting trace data.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Stream { get; set; }
		/// <summary>
		/// Trace data format of returned stream.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public StreamFormat TraceFormat { get; set; }
		/// <summary>
		/// Compression format of returned stream.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public StreamCompression StreamCompression { get; set; }
	}
}
