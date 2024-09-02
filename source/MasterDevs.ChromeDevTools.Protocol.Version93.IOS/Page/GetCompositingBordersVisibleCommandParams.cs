using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Indicates the visibility of compositing borders.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetCompositingBordersVisibleCommandParams: ICommandParams<GetCompositingBordersVisibleCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.GetCompositingBordersVisible;
	}
}
