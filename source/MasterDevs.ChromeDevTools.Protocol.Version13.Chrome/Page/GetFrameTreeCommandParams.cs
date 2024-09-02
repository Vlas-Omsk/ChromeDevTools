using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Returns present frame tree structure.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetFrameTreeCommandParams: ICommandParams<GetFrameTreeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.GetFrameTree;
	}
}
