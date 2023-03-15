using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	/// Returns content of the given resource.
	/// </summary>
	[Command(ProtocolName.Page.GetResourceContent)]
	[SupportedBy("iOS")]
	public class GetResourceContentCommand: IProtocolCommand<GetResourceContentCommandResponse>
	{
		/// <summary>
		/// Frame id to get resource for.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// URL of the resource to get content for.
		/// </summary>
		public string Url { get; set; }
	}
}
