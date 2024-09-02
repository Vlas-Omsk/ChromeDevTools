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
	public class ReasonsForCompositingLayerCommandParams: ICommandParams<ReasonsForCompositingLayerCommandResult>
	{
		public string MethodName { get; } = ProtocolName.LayerTree.ReasonsForCompositingLayer;
		/// <summary>
		/// The id of the layer for which we want to get the reasons it was composited.
		/// </summary>
		public string LayerId { get; set; }
	}
}
