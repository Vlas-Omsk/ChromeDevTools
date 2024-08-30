using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	/// Focuses the given element.
	/// </summary>
	[Command(ProtocolName.DOM.Focus)]
	[SupportedBy("iOS")]
	public class FocusCommand: ICommandParams<FocusCommandResponse>
	{
		/// <summary>
		/// Id of the node to focus.
		/// </summary>
		public long NodeId { get; set; }
	}
}
