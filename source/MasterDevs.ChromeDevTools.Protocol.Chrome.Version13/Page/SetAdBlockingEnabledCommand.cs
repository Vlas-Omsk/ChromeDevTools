using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Enable Chrome's experimental ad filter on all sites.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetAdBlockingEnabledCommand: ICommand<SetAdBlockingEnabledCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.SetAdBlockingEnabled;
		/// <summary>
		/// Whether to block ads.
		/// </summary>
		public bool Enabled { get; set; }
	}
}
