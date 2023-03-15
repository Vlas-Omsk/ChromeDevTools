using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMSnapshot
{
	[SupportedBy("Chrome")]
	public class RareIntegerData
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
