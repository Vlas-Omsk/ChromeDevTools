using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Fired when page is about to start a download.
	/// </summary>
	[Event(ProtocolName.Browser.DownloadWillBegin)]
	[SupportedBy("Chrome")]
	public class DownloadWillBeginEvent
	{
		/// <summary>
		/// Id of the frame that caused the download to begin.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Global unique identifier of the download.
		/// </summary>
		public string Guid { get; set; }
		/// <summary>
		/// URL of the resource being downloaded.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Suggested file name of the resource (the actual name of the file saved on disk may differ).
		/// </summary>
		public string SuggestedFilename { get; set; }
	}
}
