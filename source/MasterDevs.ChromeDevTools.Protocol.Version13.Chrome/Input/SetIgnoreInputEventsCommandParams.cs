using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Input
{
	/// <summary>
	/// Ignores input events (useful while auditing page).
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetIgnoreInputEventsCommandParams: ICommandParams<SetIgnoreInputEventsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Input.SetIgnoreInputEvents;
		/// <summary>
		/// Ignores input events processing when set to true.
		/// </summary>
		public bool Ignore { get; set; }
	}
}
