using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOMSnapshot
{
	/// <summary>
	/// Table of details of the post layout rendered text positions. The exact layout should not be regarded as
	/// stable and may change between versions.
	/// </summary>
	[SupportedBy("Chrome")]
	public class TextBoxSnapshot
	{
		/// <summary>
		/// Index of the layout tree node that owns this box collection.
		/// </summary>
		public long[] LayoutIndex { get; set; }
		/// <summary>
		/// The absolute position bounding box.
		/// </summary>
		public double[][] Bounds { get; set; }
		/// <summary>
		/// The starting index in characters, for this post layout textbox substring. Characters that
		/// would be represented as a surrogate pair in UTF-16 have length 2.
		/// </summary>
		public long[] Start { get; set; }
		/// <summary>
		/// The number of characters in this post layout textbox substring. Characters that would be
		/// represented as a surrogate pair in UTF-16 have length 2.
		/// </summary>
		public long[] Length { get; set; }
	}
}
