using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
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
