using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Returns present frame / resource tree structure.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetResourceTreeCommand: ICommand<GetResourceTreeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Page.GetResourceTree;
	}
}
