using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.Page
{
	/// <summary>
	/// Returns present frame / resource tree structure.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetResourceTreeCommand: ICommand<GetResourceTreeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.GetResourceTree;
	}
}
