using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.LayerTree
{
	/// <summary>
	/// Serialized fragment of layer picture along with its offset within the layer.
	/// </summary>
	[SupportedBy("Chrome")]
	public class PictureTile
	{
		/// <summary>
		/// Offset from owning layer left boundary
		/// </summary>
		public double X { get; set; }
		/// <summary>
		/// Offset from owning layer top boundary
		/// </summary>
		public double Y { get; set; }
		/// <summary>
		/// Base64-encoded snapshot data. (Encoded as a base64 string when passed over JSON)
		/// </summary>
		public string Picture { get; set; }
	}
}
