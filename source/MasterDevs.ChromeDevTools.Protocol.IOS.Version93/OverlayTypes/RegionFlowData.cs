using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.OverlayTypes
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
