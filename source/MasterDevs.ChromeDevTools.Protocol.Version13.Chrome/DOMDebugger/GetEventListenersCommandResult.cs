using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOMDebugger
{
	/// <summary>
	/// Returns event listeners of the given object.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetEventListenersCommandResult : ICommandResult
	{
		/// <summary>
		/// Array of relevant listeners.
		/// </summary>
		public EventListener[] Listeners { get; set; }
	}
}
