using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Controls whether page will emit lifecycle events.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetLifecycleEventsEnabledCommand: ICommand<SetLifecycleEventsEnabledCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.SetLifecycleEventsEnabled;
		/// <summary>
		/// If true, starts emitting lifecycle events.
		/// </summary>
		public bool Enabled { get; set; }
	}
}
