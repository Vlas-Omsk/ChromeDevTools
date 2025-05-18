using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.DOM
{
	/// <summary>
	/// Focuses the given element.
	/// </summary>

	[SupportedBy("IOS")]
	public class FocusCommand: ICommand<FocusCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.Focus;
		/// <summary>
		/// Id of the node to focus.
		/// </summary>
		public long NodeId { get; set; }
	}
}
