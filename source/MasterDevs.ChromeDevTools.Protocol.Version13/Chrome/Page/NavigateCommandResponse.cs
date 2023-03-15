using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Navigates current page to the given URL.
	/// </summary>
	[CommandResponse(ProtocolName.Page.Navigate)]
	[SupportedBy("Chrome")]
	public class NavigateCommandResponse
	{
		/// <summary>
		/// Frame id that has navigated (or failed to navigate)
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Loader identifier. This is omitted in case of same-document navigation,
		/// as the previously committed loaderId would not change.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string LoaderId { get; set; }
		/// <summary>
		/// User friendly error message, present if and only if navigation has failed.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ErrorText { get; set; }
	}
}
