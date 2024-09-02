using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Enable page Content Security Policy by-passing.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetBypassCSPCommandParams: ICommandParams<SetBypassCSPCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.SetBypassCSP;
		/// <summary>
		/// Whether to bypass page CSP.
		/// </summary>
		public bool Enabled { get; set; }
	}
}
