using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Input
{
	/// <summary>
	/// Ignores input events (useful while auditing page).
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetIgnoreInputEventsCommand: ICommand<SetIgnoreInputEventsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Input.SetIgnoreInputEvents;
		/// <summary>
		/// Ignores input events processing when set to true.
		/// </summary>
		public bool Ignore { get; set; }
	}
}
