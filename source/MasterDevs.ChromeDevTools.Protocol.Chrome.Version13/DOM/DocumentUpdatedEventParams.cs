using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
{
	/// <summary>
	/// Fired when `Document` has been totally updated. Node ids are no longer valid.
	/// </summary>
	[EventName(ProtocolName.DOM.DocumentUpdated)]
	[SupportedBy("Chrome")]
	public class DocumentUpdatedEventParams : IEventParams
	{
	}
}
