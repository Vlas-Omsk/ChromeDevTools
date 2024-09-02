using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Viewport for capturing screenshot.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Viewport
	{
		/// <summary>
		/// X offset in device independent pixels (dip).
		/// </summary>
		public double X { get; set; }
		/// <summary>
		/// Y offset in device independent pixels (dip).
		/// </summary>
		public double Y { get; set; }
		/// <summary>
		/// Rectangle width in device independent pixels (dip).
		/// </summary>
		public double Width { get; set; }
		/// <summary>
		/// Rectangle height in device independent pixels (dip).
		/// </summary>
		public double Height { get; set; }
		/// <summary>
		/// Page scale factor.
		/// </summary>
		public double Scale { get; set; }
	}
}
