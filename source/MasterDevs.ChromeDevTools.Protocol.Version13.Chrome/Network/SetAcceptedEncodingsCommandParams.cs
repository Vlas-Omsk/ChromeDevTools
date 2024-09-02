using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Sets a list of content encodings that will be accepted. Empty list means no encoding is accepted.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetAcceptedEncodingsCommandParams: ICommandParams<SetAcceptedEncodingsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.SetAcceptedEncodings;
		/// <summary>
		/// List of accepted content encodings.
		/// </summary>
		public string[] Encodings { get; set; }
	}
}
