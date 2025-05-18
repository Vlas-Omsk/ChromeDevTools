using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.ApplicationCache
{
	/// <summary>
	/// Frame identifier - manifest URL pair.
	/// </summary>
	[SupportedBy("IOS")]
	public class FrameWithManifest
	{
		/// <summary>
		/// Frame identifier.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Manifest URL.
		/// </summary>
		public string ManifestURL { get; set; }
		/// <summary>
		/// Application cache status.
		/// </summary>
		public long Status { get; set; }
	}
}
