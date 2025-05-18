using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
{
	/// <summary>
	/// Sets node name for a node with given id.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetNodeNameCommandResult : ICommandResult
	{
		/// <summary>
		/// New node's id.
		/// </summary>
		public long NodeId { get; set; }
	}
}
