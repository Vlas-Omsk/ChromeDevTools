using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Runtime
{
	/// <summary>
	/// Calls function with given declaration on the given object. Object group of the result is
	/// inherited from the target object.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CallFunctionOnCommandResult : ICommandResult
	{
		/// <summary>
		/// Call result.
		/// </summary>
		public RemoteObject Result { get; set; }
		/// <summary>
		/// Exception details.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ExceptionDetails ExceptionDetails { get; set; }
	}
}
