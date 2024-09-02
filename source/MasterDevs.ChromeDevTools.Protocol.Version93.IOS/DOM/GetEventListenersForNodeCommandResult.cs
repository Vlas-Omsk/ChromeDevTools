using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Returns event listeners relevant to the node.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetEventListenersForNodeCommandResult : ICommandResult
	{
		/// <summary>
		/// Array of relevant listeners.
		/// </summary>
		public EventListener[] Listeners { get; set; }
	}
}
