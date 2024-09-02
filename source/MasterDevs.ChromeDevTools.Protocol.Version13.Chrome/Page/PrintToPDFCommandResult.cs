using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Print page as PDF.
	/// </summary>

	[SupportedBy("Chrome")]
	public class PrintToPDFCommandResult : ICommandResult
	{
		/// <summary>
		/// Base64-encoded pdf data. Empty if |returnAsStream| is specified. (Encoded as a base64 string when passed over JSON)
		/// </summary>
		public string Data { get; set; }
		/// <summary>
		/// A handle of the stream that holds resulting PDF data.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Stream { get; set; }
	}
}
