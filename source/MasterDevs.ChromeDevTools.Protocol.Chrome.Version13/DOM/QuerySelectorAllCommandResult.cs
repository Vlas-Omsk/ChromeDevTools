using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
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
