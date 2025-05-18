using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Debugger
{
	/// <summary>
	/// Evaluates expression on a given call frame.
	/// </summary>

	[SupportedBy("Chrome")]
	public class EvaluateOnCallFrameCommandResult : ICommandResult
	{
		/// <summary>
		/// Object wrapper for the evaluation result.
		/// </summary>
		public Runtime.RemoteObject Result { get; set; }
		/// <summary>
		/// Exception details.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.ExceptionDetails ExceptionDetails { get; set; }
	}
}
