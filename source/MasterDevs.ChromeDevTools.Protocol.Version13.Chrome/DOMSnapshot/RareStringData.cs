using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOMSnapshot
{
	/// <summary>
	/// Data that is only present on rare nodes.
	/// </summary>
	[SupportedBy("Chrome")]
	public class RareStringData
	{
		/// <summary>
		/// Index
		/// </summary>
		public long[] Index { get; set; }
		/// <summary>
		/// Value
		/// </summary>
		public long[] Value { get; set; }
	}
}
