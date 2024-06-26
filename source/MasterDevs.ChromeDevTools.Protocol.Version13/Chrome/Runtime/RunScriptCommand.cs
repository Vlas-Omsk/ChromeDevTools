using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Runs script with given id in a given context.
	/// </summary>
	[Command(ProtocolName.Runtime.RunScript)]
	[SupportedBy("Chrome")]
	public class RunScriptCommand: IProtocolCommand<RunScriptCommandResponse>
	{
		/// <summary>
		/// Id of the script to run.
		/// </summary>
		public string ScriptId { get; set; }
		/// <summary>
		/// Specifies in which execution context to perform script run. If the parameter is omitted the
		/// evaluation will be performed in the context of the inspected page.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ExecutionContextId { get; set; }
		/// <summary>
		/// Symbolic group name that can be used to release multiple objects.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectGroup { get; set; }
		/// <summary>
		/// In silent mode exceptions thrown during evaluation are not reported and do not pause
		/// execution. Overrides `setPauseOnException` state.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Silent { get; set; }
		/// <summary>
		/// Determines whether Command Line API should be available during the evaluation.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludeCommandLineAPI { get; set; }
		/// <summary>
		/// Whether the result is expected to be a JSON object which should be sent by value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ReturnByValue { get; set; }
		/// <summary>
		/// Whether preview should be generated for the result.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? GeneratePreview { get; set; }
		/// <summary>
		/// Whether execution should `await` for resulting value and return once awaited promise is
		/// resolved.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? AwaitPromise { get; set; }
	}
}
