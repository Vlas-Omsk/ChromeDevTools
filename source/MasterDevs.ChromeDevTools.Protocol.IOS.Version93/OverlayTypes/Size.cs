using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.OverlayTypes
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
