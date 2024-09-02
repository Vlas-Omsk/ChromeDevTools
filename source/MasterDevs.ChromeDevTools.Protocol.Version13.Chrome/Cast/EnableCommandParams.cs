using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Cast
{
	/// <summary>
	/// Starts observing for sinks that can be used for tab mirroring, and if set,
	/// sinks compatible with |presentationUrl| as well. When sinks are found, a
	/// |sinksUpdated| event is fired.
	/// Also starts observing for issue messages. When an issue is added or removed,
	/// an |issueUpdated| event is fired.
	/// </summary>

	[SupportedBy("Chrome")]
	public class EnableCommandParams: ICommandParams<EnableCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Cast.Enable;
		/// <summary>
		/// PresentationUrl
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PresentationUrl { get; set; }
	}
}
