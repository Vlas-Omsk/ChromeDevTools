using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
{
	/// <summary>
	/// Moves node into the new container, places it before the given anchor.
	/// </summary>

	[SupportedBy("Chrome")]
	public class MoveToCommandResult : ICommandResult
	{
		/// <summary>
		/// New id of the moved node.
		/// </summary>
		public long NodeId { get; set; }
	}
}
