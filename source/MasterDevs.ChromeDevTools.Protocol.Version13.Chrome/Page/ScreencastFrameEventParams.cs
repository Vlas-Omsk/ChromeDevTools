using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Compressed image data requested by the `startScreencast`.
	/// </summary>
	[EventName(ProtocolName.Page.ScreencastFrame)]
	[SupportedBy("Chrome")]
	public class ScreencastFrameEventParams : IEventParams
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
