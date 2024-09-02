using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Executes `querySelectorAll` on a given node.
	/// </summary>

	[SupportedBy("Chrome")]
	public class QuerySelectorAllCommandResult : ICommandResult
	{
		/// <summary>
		/// Query selector result.
		/// </summary>
		public long[] NodeIds { get; set; }
	}
}
