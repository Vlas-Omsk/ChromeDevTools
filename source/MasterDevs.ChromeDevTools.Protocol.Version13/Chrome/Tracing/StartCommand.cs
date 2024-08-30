using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Tracing
{
	/// <summary>
	/// Start trace events collection.
	/// </summary>
	[Command(ProtocolName.Tracing.Start)]
	[SupportedBy("Chrome")]
	public class StartCommand: ICommandParams<StartCommandResponse>
	{
		/// <summary>
		/// Category/tag filter
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Categories { get; set; }
		/// <summary>
		/// Tracing options
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Options { get; set; }
		/// <summary>
		/// If set, the agent will issue bufferUsage events at this interval, specified in milliseconds
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double BufferUsageReportingInterval { get; set; }
		/// <summary>
		/// Whether to report trace events as series of dataCollected events or to save trace to a
		/// stream (defaults to `ReportEvents`).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TransferMode { get; set; }
		/// <summary>
		/// Trace data format to use. This only applies when using `ReturnAsStream`
		/// transfer mode (defaults to `json`).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string StreamFormat { get; set; }
		/// <summary>
		/// Compression format to use. This only applies when using `ReturnAsStream`
		/// transfer mode (defaults to `none`)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string StreamCompression { get; set; }
		/// <summary>
		/// TraceConfig
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public TraceConfig TraceConfig { get; set; }
		/// <summary>
		/// Base64-encoded serialized perfetto.protos.TraceConfig protobuf message
		/// When specified, the parameters `categories`, `options`, `traceConfig`
		/// are ignored. (Encoded as a base64 string when passed over JSON)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PerfettoConfig { get; set; }
		/// <summary>
		/// Backend type (defaults to `auto`)
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TracingBackend { get; set; }
	}
}
