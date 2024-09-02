using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Undoes the last performed action.
	/// </summary>

	[SupportedBy("IOS")]
	public class UndoCommandParams: ICommandParams<UndoCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.Undo;
	}
}
