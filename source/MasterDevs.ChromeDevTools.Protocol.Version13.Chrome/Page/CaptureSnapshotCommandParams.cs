using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Returns a snapshot of the page as a string. For MHTML format, the serialization includes
	/// iframes, shadow DOM, external resources, and element-inline styles.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CaptureSnapshotCommandParams: ICommandParams<CaptureSnapshotCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.CaptureSnapshot;
		/// <summary>
		/// Format (defaults to mhtml).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Format { get; set; }
	}
}
