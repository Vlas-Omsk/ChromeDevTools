using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Browser
{
	/// <summary>
	/// Fired when download makes progress. Last call has |done| == true.
	/// </summary>
	[EventName(ProtocolName.Browser.DownloadProgress)]
	[SupportedBy("Chrome")]
	public class DownloadProgressEventParams : IEventParams
	{
		/// <summary>
		/// Global unique identifier of the download.
		/// </summary>
		public string Guid { get; set; }
		/// <summary>
		/// Total expected bytes to download.
		/// </summary>
		public double TotalBytes { get; set; }
		/// <summary>
		/// Total bytes received.
		/// </summary>
		public double ReceivedBytes { get; set; }
		/// <summary>
		/// Download status.
		/// </summary>
		public string State { get; set; }
	}
}
