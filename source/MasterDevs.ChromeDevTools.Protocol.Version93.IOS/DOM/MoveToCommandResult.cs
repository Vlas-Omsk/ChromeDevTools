using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Moves node into the new container, places it before the given anchor.
	/// </summary>

	[SupportedBy("IOS")]
	public class MoveToCommandResult : ICommandResult
	{
		/// <summary>
		/// New id of the moved node.
		/// </summary>
		public long NodeId { get; set; }
	}
}
