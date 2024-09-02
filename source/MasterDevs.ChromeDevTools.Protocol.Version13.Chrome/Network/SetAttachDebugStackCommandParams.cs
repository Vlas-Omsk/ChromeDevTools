using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Specifies whether to attach a page script stack id in requests
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetAttachDebugStackCommandParams: ICommandParams<SetAttachDebugStackCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.SetAttachDebugStack;
		/// <summary>
		/// Whether to attach a page script stack for debugging purpose.
		/// </summary>
		public bool Enabled { get; set; }
	}
}
