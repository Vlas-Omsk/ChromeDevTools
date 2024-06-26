using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	/// Loads a resource in the context of a frame on the inspected page without cross origin checks.
	/// </summary>
	[Command(ProtocolName.Network.LoadResource)]
	[SupportedBy("iOS")]
	public class LoadResourceCommand: IProtocolCommand<LoadResourceCommandResponse>
	{
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
