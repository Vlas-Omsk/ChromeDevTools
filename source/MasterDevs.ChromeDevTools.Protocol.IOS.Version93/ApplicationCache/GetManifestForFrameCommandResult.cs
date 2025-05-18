using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.ApplicationCache
{
	/// <summary>
	/// Returns manifest URL for document in the given frame.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetManifestForFrameCommandResult : ICommandResult
	{
		/// <summary>
		/// Manifest URL for document in the given frame.
		/// </summary>
		public string ManifestURL { get; set; }
	}
}
