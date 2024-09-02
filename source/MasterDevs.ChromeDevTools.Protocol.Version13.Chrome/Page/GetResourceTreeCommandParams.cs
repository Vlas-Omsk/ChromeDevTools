using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Page
{
	/// <summary>
	/// Returns present frame / resource tree structure.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetResourceTreeCommandParams: ICommandParams<GetResourceTreeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.GetResourceTree;
	}
}
