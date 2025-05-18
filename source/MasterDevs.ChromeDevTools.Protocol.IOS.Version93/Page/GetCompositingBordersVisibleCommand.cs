using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Page
{
	/// <summary>
	/// Indicates the visibility of compositing borders.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetCompositingBordersVisibleCommand: ICommand<GetCompositingBordersVisibleCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.GetCompositingBordersVisible;
	}
}
