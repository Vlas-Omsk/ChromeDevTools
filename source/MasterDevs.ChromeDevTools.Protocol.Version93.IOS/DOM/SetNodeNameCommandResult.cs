using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Sets node name for a node with given id.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetNodeNameCommandResult : ICommandResult
	{
		/// <summary>
		/// New node's id.
		/// </summary>
		public long NodeId { get; set; }
	}
}
