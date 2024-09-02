using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Debugger
{
	/// <summary>
	/// A sample collected by evaluating a probe breakpoint action.
	/// </summary>
	[SupportedBy("IOS")]
	public class ProbeSample
	{
		/// <summary>
		/// Identifier of the probe breakpoint action that created the sample.
		/// </summary>
		public long ProbeId { get; set; }
		/// <summary>
		/// Unique identifier for this sample.
		/// </summary>
		public long SampleId { get; set; }
		/// <summary>
		/// A batch identifier which is the same for all samples taken at the same breakpoint hit.
		/// </summary>
		public long BatchId { get; set; }
		/// <summary>
		/// Timestamp of when the sample was taken.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Contents of the sample.
		/// </summary>
		public Runtime.RemoteObject Payload { get; set; }
	}
}
