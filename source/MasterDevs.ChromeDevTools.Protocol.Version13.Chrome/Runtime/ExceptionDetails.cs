using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Runtime
{
	/// <summary>
	/// Detailed information about exception (or error) that was thrown during script compilation or
	/// execution.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ExceptionDetails
	{
		/// <summary>
		/// Exception id.
		/// </summary>
		public long ExceptionId { get; set; }
		/// <summary>
		/// Exception text, which should be used together with exception object when available.
		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// Line number of the exception location (0-based).
		/// </summary>
		public long LineNumber { get; set; }
		/// <summary>
		/// Column number of the exception location (0-based).
		/// </summary>
		public long ColumnNumber { get; set; }
		/// <summary>
		/// Script ID of the exception location.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ScriptId { get; set; }
		/// <summary>
		/// URL of the exception location, to be used when the script was not reported.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Url { get; set; }
		/// <summary>
		/// JavaScript stack trace if available.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public StackTrace StackTrace { get; set; }
		/// <summary>
		/// Exception object if available.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RemoteObject Exception { get; set; }
		/// <summary>
		/// Identifier of the context where exception happened.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ExecutionContextId { get; set; }
		/// <summary>
		/// Dictionary with entries of meta data that the client associated
		/// with this exception, such as information about associated network
		/// requests, etc.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object ExceptionMetaData { get; set; }
	}
}
