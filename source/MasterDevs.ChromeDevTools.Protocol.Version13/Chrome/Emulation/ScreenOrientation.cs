using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Screen orientation.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ScreenOrientation
	{
		/// <summary>
		/// Orientation type.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Orientation angle.
		/// </summary>
		public long Angle { get; set; }
	}
}
