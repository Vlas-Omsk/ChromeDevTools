using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.OverlayTypes
{
	[SupportedBy("iOS")]
	public class ContentFlowData
	{
		/// <summary>
		/// Name
		/// </summary>
		public string Name { get; set; }
	}
}
