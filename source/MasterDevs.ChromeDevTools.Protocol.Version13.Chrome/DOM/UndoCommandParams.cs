using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Undoes the last performed action.
	/// </summary>

	[SupportedBy("Chrome")]
	public class UndoCommandParams: ICommandParams<UndoCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.Undo;
	}
}
