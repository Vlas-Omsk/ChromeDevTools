using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Capture a snapshot of the specified node that does not include unrelated layers.
	/// </summary>

	[SupportedBy("IOS")]
	public class SnapshotNodeCommandResult : ICommandResult
	{
		/// <summary>
		/// Base64-encoded image data (PNG).
		/// </summary>
		public string DataURL { get; set; }
	}
}
