using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.LayerTree
{
	/// <summary>
	/// Returns the layer tree structure of the current page.
	/// </summary>

	[SupportedBy("IOS")]
	public class LayersForNodeCommandResult : ICommandResult
	{
		/// <summary>
		/// Child layers.
		/// </summary>
		public Layer[] Layers { get; set; }
	}
}
