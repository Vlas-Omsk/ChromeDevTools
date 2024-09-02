using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Finds nodes with a given computed style in a subtree.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetNodesForSubtreeByStyleCommandResult : ICommandResult
	{
		/// <summary>
		/// Resulting nodes.
		/// </summary>
		public long[] NodeIds { get; set; }
	}
}
