using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Page
{
	/// <summary>
	/// Fired when opening document to write to.
	/// </summary>
	[EventName(ProtocolName.Page.DocumentOpened)]
	[SupportedBy("Chrome")]
	public class DocumentOpenedEventParams : IEventParams
	{
		/// <summary>
		/// Frame object.
		/// </summary>
		public Frame Frame { get; set; }
	}
}
