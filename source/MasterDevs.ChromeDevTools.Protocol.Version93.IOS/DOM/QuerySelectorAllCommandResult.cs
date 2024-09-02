using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Executes <code>querySelectorAll</code> on a given node.
	/// </summary>

	[SupportedBy("IOS")]
	public class QuerySelectorAllCommandResult : ICommandResult
	{
		/// <summary>
		/// Query selector result.
		/// </summary>
		public long[] NodeIds { get; set; }
	}
}
