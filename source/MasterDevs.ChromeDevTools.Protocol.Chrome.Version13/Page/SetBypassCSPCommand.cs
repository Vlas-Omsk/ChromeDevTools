using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Enable page Content Security Policy by-passing.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetBypassCSPCommand: ICommand<SetBypassCSPCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.SetBypassCSP;
		/// <summary>
		/// Whether to bypass page CSP.
		/// </summary>
		public bool Enabled { get; set; }
	}
}
