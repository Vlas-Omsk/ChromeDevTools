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
	public class LoadResourceCommandParams: ICommandParams<LoadResourceCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.LoadResource;
		/// <summary>
		/// Frame to load the resource from.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// URL of the resource to load.
		/// </summary>
		public string Url { get; set; }
	}
}
