using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
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
