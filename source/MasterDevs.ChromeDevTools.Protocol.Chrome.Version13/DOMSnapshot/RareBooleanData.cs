using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOMSnapshot
{
	[SupportedBy("Chrome")]
	public class RareBooleanData
	{
		/// <summary>
		/// Index
		/// </summary>
		public long[] Index { get; set; }
	}
}
