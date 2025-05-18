using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Page
{
	/// <summary>
	/// Capture a snapshot of the page within the specified rectangle and coordinate system.
	/// </summary>

	[SupportedBy("IOS")]
	public class SnapshotRectCommandResult : ICommandResult
	{
		/// <summary>
		/// Base64-encoded image data (PNG).
		/// </summary>
		public string DataURL { get; set; }
	}
}
