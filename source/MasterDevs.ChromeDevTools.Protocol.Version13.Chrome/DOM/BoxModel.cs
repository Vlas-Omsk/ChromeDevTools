using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Box model.
	/// </summary>
	[SupportedBy("Chrome")]
	public class BoxModel
	{
		/// <summary>
		/// Content box
		/// </summary>
		public double[] Content { get; set; }
		/// <summary>
		/// Padding box
		/// </summary>
		public double[] Padding { get; set; }
		/// <summary>
		/// Border box
		/// </summary>
		public double[] Border { get; set; }
		/// <summary>
		/// Margin box
		/// </summary>
		public double[] Margin { get; set; }
		/// <summary>
		/// Node width
		/// </summary>
		public long Width { get; set; }
		/// <summary>
		/// Node height
		/// </summary>
		public long Height { get; set; }
		/// <summary>
		/// Shape outside coordinates
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ShapeOutsideInfo ShapeOutside { get; set; }
	}
}
