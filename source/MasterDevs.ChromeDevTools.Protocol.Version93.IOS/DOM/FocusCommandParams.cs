using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Focuses the given element.
	/// </summary>

	[SupportedBy("IOS")]
	public class FocusCommandParams: ICommandParams<FocusCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.Focus;
		/// <summary>
		/// Id of the node to focus.
		/// </summary>
		public long NodeId { get; set; }
	}
}
