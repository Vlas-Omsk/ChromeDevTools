using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Debugger
{
	/// <summary>
	/// Continues execution until specific location is reached.
	/// </summary>

	[SupportedBy("Chrome")]
	public class ContinueToLocationCommandParams: ICommandParams<ContinueToLocationCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Debugger.ContinueToLocation;
		/// <summary>
		/// Location to continue to.
		/// </summary>
		public Location Location { get; set; }
		/// <summary>
		/// TargetCallFrames
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TargetCallFrames { get; set; }
	}
}
