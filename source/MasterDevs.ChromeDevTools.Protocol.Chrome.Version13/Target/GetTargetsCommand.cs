using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Target
{
	/// <summary>
	/// Retrieves a list of available targets.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetTargetsCommand: ICommand<GetTargetsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Target.GetTargets;
		/// <summary>
		/// Only targets matching filter will be reported. If filter is not specified
		/// and target discovery is currently enabled, a filter used for target discovery
		/// is used for consistency.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public FilterEntry[] Filter { get; set; }
	}
}
