using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.OverlayTypes
{
	[SupportedBy("IOS")]
	public class RegionFlowData
	{
		/// <summary>
		/// Regions
		/// </summary>
		public Region[] Regions { get; set; }
		/// <summary>
		/// Name
		/// </summary>
		public string Name { get; set; }
	}
}
