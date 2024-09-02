using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Marks last undoable state.
	/// </summary>

	[SupportedBy("Chrome")]
	public class MarkUndoableStateCommandParams: ICommandParams<MarkUndoableStateCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.MarkUndoableState;
	}
}
