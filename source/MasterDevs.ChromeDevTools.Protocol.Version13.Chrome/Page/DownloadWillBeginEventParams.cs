using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Fired when page is about to start a download.
	/// Deprecated. Use Browser.downloadWillBegin instead.
	/// </summary>
	[EventName(ProtocolName.Page.DownloadWillBegin)]
	[SupportedBy("Chrome")]
	public class DownloadWillBeginEventParams : IEventParams
	{
		/// <summary>
		/// Id of the frame that caused download to begin.
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
