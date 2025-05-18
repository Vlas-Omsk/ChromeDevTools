using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.LayerTree
{
	[EventName(ProtocolName.LayerTree.LayerTreeDidChange)]
	[SupportedBy("Chrome")]
	public class LayerTreeDidChangeEventParams : IEventParams
	{
		/// <summary>
		/// Layer tree, absent if not in the comspositing mode.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Layer[] Layers { get; set; }
	}
}
