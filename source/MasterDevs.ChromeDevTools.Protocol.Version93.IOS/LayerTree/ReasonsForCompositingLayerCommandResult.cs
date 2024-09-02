using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.LayerTree
{
	/// <summary>
	/// Provides the reasons why the given layer was composited.
	/// </summary>

	[SupportedBy("IOS")]
	public class ReasonsForCompositingLayerCommandResult : ICommandResult
	{
		/// <summary>
		/// An object containing the reasons why the layer was composited as properties.
		/// </summary>
		public CompositingReasons CompositingReasons { get; set; }
	}
}
