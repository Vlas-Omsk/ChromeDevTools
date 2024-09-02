using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Grab an archive of the page.
	/// </summary>

	[SupportedBy("IOS")]
	public class ArchiveCommandResult : ICommandResult
	{
		/// <summary>
		/// Base64-encoded web archive.
		/// </summary>
		public string Data { get; set; }
	}
}
