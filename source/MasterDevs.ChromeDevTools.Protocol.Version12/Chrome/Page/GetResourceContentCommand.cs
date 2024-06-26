using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Returns content of the given resource.
	/// </summary>
	[Command(ProtocolName.Page.GetResourceContent)]
	[SupportedBy("Chrome")]
	public class GetResourceContentCommand: IProtocolCommand<GetResourceContentCommandResponse>
	{
		/// <summary>
		/// Gets or sets Frame id to get resource for.
		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets URL of the resource to get content for.
		/// </summary>
		public string Url { get; set; }
	}
}
