using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.LayerTree
{
	/// <summary>
	/// A rectangle.
	/// </summary>
	[SupportedBy("iOS")]
	public class IntRect
	{
		/// <summary>
		/// The x position.
		/// </summary>
		public long X { get; set; }
		/// <summary>
		/// The y position.
		/// </summary>
		public long Y { get; set; }
		/// <summary>
		/// The width metric.
		/// </summary>
		public long Width { get; set; }
		/// <summary>
		/// The height metric.
		/// </summary>
		public long Height { get; set; }
	}
}
