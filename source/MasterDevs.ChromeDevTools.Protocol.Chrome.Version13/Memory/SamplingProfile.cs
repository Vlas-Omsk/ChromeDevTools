using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Memory
{
	/// <summary>
	/// Array of heap profile samples.
	/// </summary>
	[SupportedBy("Chrome")]
	public class SamplingProfile
	{
		/// <summary>
		/// Samples
		/// </summary>
		public SamplingProfileNode[] Samples { get; set; }
		/// <summary>
		/// Modules
		/// </summary>
		public Module[] Modules { get; set; }
	}
}
