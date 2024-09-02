using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.LayerTree
{
	/// <summary>
	/// Provides the reasons why the given layer was composited.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CompositingReasonsCommandParams: ICommandParams<CompositingReasonsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.LayerTree.CompositingReasons;
		/// <summary>
		/// The id of the layer for which we want to get the reasons it was composited.
		/// </summary>
		public string LayerId { get; set; }
	}
}
