using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
{
	/// <summary>
	/// Sets a list of content encodings that will be accepted. Empty list means no encoding is accepted.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetAcceptedEncodingsCommand: ICommand<SetAcceptedEncodingsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.SetAcceptedEncodings;
		/// <summary>
		/// List of accepted content encodings.
		/// </summary>
		public string[] Encodings { get; set; }
	}
}
