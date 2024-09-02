using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.LayerTree
{
	[EventName(ProtocolName.LayerTree.LayerTreeDidChange)]
	[SupportedBy("IOS")]
	public class LayerTreeDidChangeEventParams : IEventParams
	{
	}
}
