using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.LayerTree
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
