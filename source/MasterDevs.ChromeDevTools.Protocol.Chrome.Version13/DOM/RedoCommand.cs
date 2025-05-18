using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
{
	/// <summary>
	/// Re-does the last undone action.
	/// </summary>

	[SupportedBy("Chrome")]
	public class RedoCommand: ICommand<RedoCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.Redo;
	}
}
