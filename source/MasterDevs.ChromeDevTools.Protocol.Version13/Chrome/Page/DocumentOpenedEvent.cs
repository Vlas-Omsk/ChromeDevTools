using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Fired when opening document to write to.
	/// </summary>
	[Event(ProtocolName.Page.DocumentOpened)]
	[SupportedBy("Chrome")]
	public class DocumentOpenedEvent
	{
		/// <summary>
		/// Frame object.
		/// </summary>
		public Frame Frame { get; set; }
	}
}
