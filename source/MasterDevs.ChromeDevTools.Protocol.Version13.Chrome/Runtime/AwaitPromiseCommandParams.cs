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
	public class AwaitPromiseCommandParams: ICommandParams<AwaitPromiseCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.AwaitPromise;
		/// <summary>
		/// Identifier of the promise.
		/// </summary>
		public string PromiseObjectId { get; set; }
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
	}
}
