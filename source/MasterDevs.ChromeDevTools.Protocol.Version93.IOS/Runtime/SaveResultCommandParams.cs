using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Runtime
{
	/// <summary>
	/// Assign a saved result index to this value.
	/// </summary>

	[SupportedBy("IOS")]
	public class SaveResultCommandParams: ICommandParams<SaveResultCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Runtime.SaveResult;
		/// <summary>
		/// Id or value of the object to save.
		/// </summary>
		public CallArgument Value { get; set; }
		/// <summary>
		/// Unique id of the execution context. To specify in which execution context script evaluation should be performed. If not provided, determine from the CallArgument's objectId.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ContextId { get; set; }
	}
}
