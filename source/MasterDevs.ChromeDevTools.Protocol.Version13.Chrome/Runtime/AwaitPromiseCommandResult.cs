using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Runtime
{
	/// <summary>
	/// Add handler to promise with given promise object id.
	/// </summary>

	[SupportedBy("Chrome")]
	public class AwaitPromiseCommandResult : ICommandResult
	{
		/// <summary>
		/// Promise result. Will contain rejected value if promise was rejected.
		/// </summary>
		public RemoteObject Result { get; set; }
		/// <summary>
		/// Exception details if stack strace is available.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ExceptionDetails ExceptionDetails { get; set; }
	}
}
