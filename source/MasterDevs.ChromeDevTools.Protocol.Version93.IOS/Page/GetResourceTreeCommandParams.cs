using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.Page
{
	/// <summary>
	/// Returns present frame / resource tree structure.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetResourceTreeCommandParams: ICommandParams<GetResourceTreeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.GetResourceTree;
	}
}
