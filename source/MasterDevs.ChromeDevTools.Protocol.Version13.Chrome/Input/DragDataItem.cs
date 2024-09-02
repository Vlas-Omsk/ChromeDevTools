using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Input
{
	[SupportedBy("Chrome")]
	public class DragDataItem
	{
		/// <summary>
		/// Mime type of the dragged data.
		/// </summary>
		public string MimeType { get; set; }
		/// <summary>
		/// Depending of the value of `mimeType`, it contains the dragged link,
		/// text, HTML markup or any other data.
		/// </summary>
		public string Data { get; set; }
		/// <summary>
		/// Title associated with a link. Only valid when `mimeType` == "text/uri-list".
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Title { get; set; }
		/// <summary>
		/// Stores the base URL for the contained markup. Only valid when `mimeType`
		/// == "text/html".
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BaseURL { get; set; }
	}
}
