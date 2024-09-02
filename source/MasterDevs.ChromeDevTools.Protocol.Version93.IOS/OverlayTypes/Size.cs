using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.OverlayTypes
{
	[SupportedBy("IOS")]
	public class Size
	{
		/// <summary>
		/// Width
		/// </summary>
		public long Width { get; set; }
		/// <summary>
		/// Height
		/// </summary>
		public long Height { get; set; }
	}
}
