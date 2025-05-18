using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Debugger
{
	/// <summary>
	/// Fires when a new probe sample is collected.
	/// </summary>
	[EventName(ProtocolName.Debugger.DidSampleProbe)]
	[SupportedBy("IOS")]
	public class DidSampleProbeEventParams : IEventParams
	{
		/// <summary>
		/// A collected probe sample.
		/// </summary>
		public ProbeSample Sample { get; set; }
	}
}
