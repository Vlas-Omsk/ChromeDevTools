using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.LayerTree
{
	/// <summary>
	/// Provides the reasons why the given layer was composited.
	/// </summary>
	[Command(ProtocolName.LayerTree.CompositingReasons)]
	[SupportedBy("Chrome")]
	public class CompositingReasonsCommand: ICommandParams<CompositingReasonsCommandResponse>
	{
		/// <summary>
		/// The id of the layer for which we want to get the reasons it was composited.
		/// </summary>
		public string LayerId { get; set; }
	}
}
