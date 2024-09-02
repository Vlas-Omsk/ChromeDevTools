using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Executes `querySelector` on a given node.
	/// </summary>

	[SupportedBy("Chrome")]
	public class QuerySelectorCommandResult : ICommandResult
	{
		/// <summary>
		/// Query selector result.
		/// </summary>
		public long NodeId { get; set; }
	}
}
