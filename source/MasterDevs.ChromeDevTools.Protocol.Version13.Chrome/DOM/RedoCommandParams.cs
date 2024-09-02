using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Re-does the last undone action.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RedoCommandParams: ICommandParams<RedoCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.Redo;
	}
}
