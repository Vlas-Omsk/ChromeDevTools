using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Controls whether to discover available targets and notify via
	/// `targetCreated/targetInfoChanged/targetDestroyed` events.
	/// </summary>
	[Command(ProtocolName.Target.SetDiscoverTargets)]
	[SupportedBy("Chrome")]
	public class SetDiscoverTargetsCommand: IProtocolCommand<SetDiscoverTargetsCommandResponse>
	{
		/// <summary>
		/// Whether to discover available targets.
		/// </summary>
		public bool Discover { get; set; }
		/// <summary>
		/// Only targets matching filter will be attached. If `discover` is false,
		/// `filter` must be omitted or empty.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public FilterEntry[] Filter { get; set; }
	}
}
