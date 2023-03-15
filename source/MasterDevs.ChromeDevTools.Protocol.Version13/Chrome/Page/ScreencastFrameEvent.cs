using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Compressed image data requested by the `startScreencast`.
	/// </summary>
	[Event(ProtocolName.Page.ScreencastFrame)]
	[SupportedBy("Chrome")]
	public class ScreencastFrameEvent
	{
		/// <summary>
		/// Base64-encoded compressed image. (Encoded as a base64 string when passed over JSON)
		/// </summary>
		public string Data { get; set; }
		/// <summary>
		/// Screencast frame metadata.
		/// </summary>
		public ScreencastFrameMetadata Metadata { get; set; }
		/// <summary>
		/// Frame number.
		/// </summary>
		public long SessionId { get; set; }
	}
}
