using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.DOM
{
	/// <summary>
	/// Executes <code>querySelector</code> on a given node.
	/// </summary>

	[SupportedBy("IOS")]
	public class QuerySelectorCommandResult : ICommandResult
	{
		/// <summary>
		/// Query selector result.
		/// </summary>
		public long NodeId { get; set; }
	}
}
