using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{

	[SupportedBy("Chrome")]
	public class SetEmitTouchEventsForMouseCommandParams: ICommandParams<SetEmitTouchEventsForMouseCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetEmitTouchEventsForMouse;
		/// <summary>
		/// Whether touch emulation based on mouse input should be enabled.
		/// </summary>
		public bool Enabled { get; set; }
		/// <summary>
		/// Touch/gesture events configuration. Default: current platform.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Configuration { get; set; }
	}
}
