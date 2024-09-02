using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	/// <summary>
	/// This object represents a region that flows from a Named Flow.
	/// </summary>
	[SupportedBy("IOS")]
	public class Region
	{
		/// <summary>
		/// The "overset" attribute of a Named Flow.
		/// </summary>
		public string RegionOverset { get; set; }
		/// <summary>
		/// The corresponding DOM node id.
		/// </summary>
		public long NodeId { get; set; }
	}
}
