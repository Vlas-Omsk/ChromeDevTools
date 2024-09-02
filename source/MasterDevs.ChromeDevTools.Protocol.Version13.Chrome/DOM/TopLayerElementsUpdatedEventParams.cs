using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
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
