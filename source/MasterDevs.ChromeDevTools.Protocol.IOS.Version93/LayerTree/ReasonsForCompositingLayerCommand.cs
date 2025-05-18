using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.LayerTree
{
	/// <summary>
	/// Provides the reasons why the given layer was composited.
	/// </summary>

	[SupportedBy("IOS")]
	public class ReasonsForCompositingLayerCommand: ICommand<ReasonsForCompositingLayerCommandResult>
	{
		public string MethodName { get; } = ProtocolName.LayerTree.ReasonsForCompositingLayer;
		/// <summary>
		/// The id of the layer for which we want to get the reasons it was composited.
		/// </summary>
		public string LayerId { get; set; }
	}
}
