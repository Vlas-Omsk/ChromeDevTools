using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Runtime
{
	/// <summary>
	/// Evaluates expression on global object.
	/// </summary>

	[SupportedBy("Chrome")]
	public class EvaluateCommandParams: ICommandParams<EvaluateCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.Evaluate;
		/// <summary>
		/// Expression to evaluate.
		/// </summary>
		public string Expression { get; set; }
		/// <summary>
		/// Symbolic group name that can be used to release multiple objects.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectGroup { get; set; }
		/// <summary>
		/// Determines whether Command Line API should be available during the evaluation.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludeCommandLineAPI { get; set; }
		/// <summary>
		/// In silent mode exceptions thrown during evaluation are not reported and do not pause
		/// execution. Overrides `setPauseOnException` state.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Silent { get; set; }
		/// <summary>
		/// Specifies in which execution context to perform evaluation. If the parameter is omitted the
		/// evaluation will be performed in the context of the inspected page.
		/// This is mutually exclusive with `uniqueContextId`, which offers an
		/// alternative way to identify the execution context that is more reliable
		/// in a multi-process environment.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ContextId { get; set; }
		/// <summary>
		/// Whether the result is expected to be a JSON object that should be sent by value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ReturnByValue { get; set; }
		/// <summary>
		/// Whether preview should be generated for the result.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? GeneratePreview { get; set; }
		/// <summary>
		/// Whether execution should be treated as initiated by user in the UI.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? UserGesture { get; set; }
		/// <summary>
		/// Whether execution should `await` for resulting value and return once awaited promise is
		/// resolved.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? AwaitPromise { get; set; }
		/// <summary>
		/// Whether to throw an exception if side effect cannot be ruled out during evaluation.
		/// This implies `disableBreaks` below.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ThrowOnSideEffect { get; set; }
		/// <summary>
		/// Terminate execution after timing out (number of milliseconds).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Timeout { get; set; }
		/// <summary>
		/// Disable breakpoints during execution.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? DisableBreaks { get; set; }
		/// <summary>
		/// Setting this flag to true enables `let` re-declaration and top-level `await`.
		/// Note that `let` variables can only be re-declared if they originate from
		/// `replMode` themselves.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ReplMode { get; set; }
		/// <summary>
		/// The Content Security Policy (CSP) for the target might block 'unsafe-eval'
		/// which includes eval(), Function(), setTimeout() and setInterval()
		/// when called with non-callable arguments. This flag bypasses CSP for this
		/// evaluation and allows unsafe-eval. Defaults to true.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? AllowUnsafeEvalBlockedByCSP { get; set; }
		/// <summary>
		/// An alternative way to specify the execution context to evaluate in.
		/// Compared to contextId that may be reused across processes, this is guaranteed to be
		/// system-unique, so it can be used to prevent accidental evaluation of the expression
		/// in context different than intended (e.g. as a result of navigation across process
		/// boundaries).
		/// This is mutually exclusive with `contextId`.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string UniqueContextId { get; set; }
		/// <summary>
		/// Whether the result should be serialized according to https://w3c.github.io/webdriver-bidi.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? GenerateWebDriverValue { get; set; }
	}
}
