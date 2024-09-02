using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Debugger
{
	/// <summary>
	/// The pause reason auxiliary data when paused because of an assertion.
	/// </summary>
	[SupportedBy("IOS")]
	public class AssertPauseReason
	{
		/// <summary>
		/// The console.assert message string if provided.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Message { get; set; }
	}
}
