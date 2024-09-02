using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	/// <summary>
	/// Edits JavaScript source live.
	/// 
	/// In general, functions that are currently on the stack can not be edited with
	/// a single exception: If the edited function is the top-most stack frame and
	/// that is the only activation of that function on the stack. In this case
	/// the live edit will be successful and a `Debugger.restartFrame` for the
	/// top-most function is automatically triggered.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetScriptSourceCommandResult : ICommandResult
	{
		/// <summary>
		/// New stack trace in case editing has happened while VM was stopped.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CallFrame[] CallFrames { get; set; }
		/// <summary>
		/// Whether current call stack  was modified after applying the changes.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? StackChanged { get; set; }
		/// <summary>
		/// Async stack trace, if any.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.StackTrace AsyncStackTrace { get; set; }
		/// <summary>
		/// Async stack trace, if any.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.StackTraceId AsyncStackTraceId { get; set; }
		/// <summary>
		/// Whether the operation was successful or not. Only `Ok` denotes a
		/// successful live edit while the other enum variants denote why
		/// the live edit failed.
		/// </summary>
		public string Status { get; set; }
		/// <summary>
		/// Exception details if any. Only present when `status` is `CompileError`.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.ExceptionDetails ExceptionDetails { get; set; }
	}
}
