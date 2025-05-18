using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
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
