using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// CSS Shape Outside details.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ShapeOutsideInfo
	{
		/// <summary>
		/// Shape bounds
		/// </summary>
		public double[] Bounds { get; set; }
		/// <summary>
		/// Shape coordinate details
		/// </summary>
		public object[] Shape { get; set; }
		/// <summary>
		/// Margin shape bounds
		/// </summary>
		public object[] MarginShape { get; set; }
	}
}
