using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Network
{
	/// <summary>
	/// Loads a resource in the context of a frame on the inspected page without cross origin checks.
	/// </summary>

	[SupportedBy("IOS")]
	public class LoadResourceCommandResult : ICommandResult
	{
		/// <summary>
		/// Resource content.
		/// </summary>
		public string Content { get; set; }
		/// <summary>
		/// Resource mimeType.
		/// </summary>
		public string MimeType { get; set; }
		/// <summary>
		/// HTTP response status code.
		/// </summary>
		public double Status { get; set; }
	}
}
