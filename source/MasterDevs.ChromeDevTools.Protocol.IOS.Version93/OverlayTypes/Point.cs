using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.OverlayTypes
{
	[SupportedBy("IOS")]
	public class Point
	{
		/// <summary>
		/// X
		/// </summary>
		public double X { get; set; }
		/// <summary>
		/// Y
		/// </summary>
		public double Y { get; set; }
	}
}
