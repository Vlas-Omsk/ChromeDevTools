using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Capture page screenshot.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CaptureScreenshotCommandResult : ICommandResult
	{
		/// <summary>
		/// Base64-encoded image data. (Encoded as a base64 string when passed over JSON)
		/// </summary>
		public string Data { get; set; }
	}
}
