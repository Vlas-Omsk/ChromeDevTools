using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.OverlayTypes
{
	[SupportedBy("iOS")]
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
