using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Runtime
{
	/// <summary>
	/// Evaluates expression on global object.
	/// </summary>

	[SupportedBy("IOS")]
	public class EvaluateCommandResult : ICommandResult
	{
		/// <summary>
		/// Evaluation result.
		/// </summary>
		public RemoteObject Result { get; set; }
		/// <summary>
		/// True if the result was thrown during the evaluation.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? WasThrown { get; set; }
		/// <summary>
		/// If the result was saved, this is the $n index that can be used to access the value.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? SavedResultIndex { get; set; }
	}
}
