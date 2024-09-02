using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.LayerTree
{
	/// <summary>
	/// Disables compositing tree inspection.
	/// </summary>

	[SupportedBy("IOS")]
	public class DisableCommandParams: ICommandParams<DisableCommandResult>
	{
		public string MethodName { get; } = ProtocolName.LayerTree.Disable;
	}
}
