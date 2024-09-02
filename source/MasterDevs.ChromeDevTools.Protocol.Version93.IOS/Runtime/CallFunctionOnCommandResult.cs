using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Runtime
{
	/// <summary>
	/// Calls function with given declaration on the given object. Object group of the result is inherited from the target object.
	/// </summary>

	[SupportedBy("IOS")]
	public class CallFunctionOnCommandResult : ICommandResult
	{
		/// <summary>
		/// Call result.
		/// </summary>
		public RemoteObject Result { get; set; }
		/// <summary>
		/// True if the result was thrown during the evaluation.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? WasThrown { get; set; }
	}
}
