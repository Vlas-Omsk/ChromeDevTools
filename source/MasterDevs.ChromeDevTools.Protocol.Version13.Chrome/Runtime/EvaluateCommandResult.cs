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
	public class EvaluateCommandResult : ICommandResult
	{
		/// <summary>
		/// Evaluation result.
		/// </summary>
		public RemoteObject Result { get; set; }
		/// <summary>
		/// Exception details.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ExceptionDetails ExceptionDetails { get; set; }
	}
}
