using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOMDebugger
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
