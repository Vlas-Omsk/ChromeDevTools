using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.LayerTree
{
	/// <summary>
	/// Provides the reasons why the given layer was composited.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CompositingReasonsCommand: ICommand<CompositingReasonsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.LayerTree.CompositingReasons;
		/// <summary>
		/// The id of the layer for which we want to get the reasons it was composited.
		/// </summary>
		public string LayerId { get; set; }
	}
}
