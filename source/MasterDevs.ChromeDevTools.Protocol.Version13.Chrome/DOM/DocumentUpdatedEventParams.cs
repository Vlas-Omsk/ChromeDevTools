using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
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
