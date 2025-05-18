using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.LayerTree
{
	/// <summary>
	/// Disables compositing tree inspection.
	/// </summary>

	[SupportedBy("IOS")]
	public class DisableCommand: ICommand<DisableCommandResult>
	{
		public string MethodName { get; } = ProtocolName.LayerTree.Disable;
	}
}
