using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Emulation
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
