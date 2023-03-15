using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	/// The pause reason auxiliary data when paused because of an assertion.
	/// </summary>
	[SupportedBy("iOS")]
	public class AssertPauseReason
	{
		/// <summary>
		/// The console.assert message string if provided.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Message { get; set; }
	}
}
