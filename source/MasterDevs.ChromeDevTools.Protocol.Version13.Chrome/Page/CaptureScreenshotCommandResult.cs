using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
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
