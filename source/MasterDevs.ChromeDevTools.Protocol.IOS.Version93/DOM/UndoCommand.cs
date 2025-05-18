using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.DOM
{
	/// <summary>
	/// Undoes the last performed action.
	/// </summary>

	[SupportedBy("IOS")]
	public class UndoCommand: ICommand<UndoCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.Undo;
	}
}
