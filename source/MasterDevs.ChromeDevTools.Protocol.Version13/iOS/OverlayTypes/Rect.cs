using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.OverlayTypes
{
	/// <summary>
	/// A rectangle specified by a reference coordinate and width/height offsets.
	/// </summary>
	[SupportedBy("iOS")]
	public class Rect
	{
		/// <summary>
		/// X
		/// </summary>
		public double X { get; set; }
		/// <summary>
		/// Y
		/// </summary>
		public double Y { get; set; }
		/// <summary>
		/// Width
		/// </summary>
		public double Width { get; set; }
		/// <summary>
		/// Height
		/// </summary>
		public double Height { get; set; }
	}
}
