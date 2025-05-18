using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
{
	/// <summary>
	/// Specifies whether to attach a page script stack id in requests
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetAttachDebugStackCommand: ICommand<SetAttachDebugStackCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.SetAttachDebugStack;
		/// <summary>
		/// Whether to attach a page script stack for debugging purpose.
		/// </summary>
		public bool Enabled { get; set; }
	}
}
