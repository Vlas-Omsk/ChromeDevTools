using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.DOM
{
	/// <summary>
	/// Marks last undoable state.
	/// </summary>

	[SupportedBy("IOS")]
	public class MarkUndoableStateCommand: ICommand<MarkUndoableStateCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.MarkUndoableState;
	}
}
