using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
{
	/// <summary>
	/// Called when top layer elements are changed.
	/// </summary>
	[EventName(ProtocolName.DOM.TopLayerElementsUpdated)]
	[SupportedBy("Chrome")]
	public class TopLayerElementsUpdatedEventParams : IEventParams
	{
	}
}
