using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Retrieves a list of available targets.
	/// </summary>
	[Command(ProtocolName.Target.GetTargets)]
	[SupportedBy("Chrome")]
	public class GetTargetsCommand: IProtocolCommand<GetTargetsCommandResponse>
	{
		/// <summary>
		/// Only targets matching filter will be reported. If filter is not specified
		/// and target discovery is currently enabled, a filter used for target discovery
		/// is used for consistency.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public FilterEntry[] Filter { get; set; }
	}
}
