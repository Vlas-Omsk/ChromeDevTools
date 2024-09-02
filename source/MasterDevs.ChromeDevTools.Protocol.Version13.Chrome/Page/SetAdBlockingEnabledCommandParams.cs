using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Enable Chrome's experimental ad filter on all sites.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetAdBlockingEnabledCommandParams: ICommandParams<SetAdBlockingEnabledCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.SetAdBlockingEnabled;
		/// <summary>
		/// Whether to block ads.
		/// </summary>
		public bool Enabled { get; set; }
	}
}
