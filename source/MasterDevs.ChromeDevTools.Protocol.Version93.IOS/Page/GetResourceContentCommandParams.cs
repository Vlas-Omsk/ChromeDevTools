using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Returns content of the given resource.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetResourceContentCommandParams: ICommandParams<GetResourceContentCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.GetResourceContent;
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
