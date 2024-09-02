using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Debugger
{
	/// <summary>
	/// Evaluates expression on a given call frame.
	/// </summary>

	[SupportedBy("IOS")]
	public class EvaluateOnCallFrameCommandResult : ICommandResult
	{
		/// <summary>
		/// Object wrapper for the evaluation result.
		/// </summary>
		public Runtime.RemoteObject Result { get; set; }
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
