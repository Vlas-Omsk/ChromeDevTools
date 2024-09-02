using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Timeline
{
	/// <summary>
	/// Profile.
	/// </summary>
	[SupportedBy("IOS")]
	public class CPUProfile
	{
		/// <summary>
		/// Top level nodes in the stack.
		/// </summary>
		public CPUProfileNode[] RootNodes { get; set; }
		/// <summary>
		/// IdleTime
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double IdleTime { get; set; }
	}
}
