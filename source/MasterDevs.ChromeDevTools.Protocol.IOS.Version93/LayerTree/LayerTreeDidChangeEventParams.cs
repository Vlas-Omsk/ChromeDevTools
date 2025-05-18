using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.LayerTree
{
	[EventName(ProtocolName.LayerTree.LayerTreeDidChange)]
	[SupportedBy("IOS")]
	public class LayerTreeDidChangeEventParams : IEventParams
	{
	}
}
