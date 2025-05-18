using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
{
	/// <summary>
	/// Creates a deep copy of the specified node and places it into the target container before the
	/// given anchor.
	/// </summary>

	[SupportedBy("Chrome")]
	public class CopyToCommandResult : ICommandResult
	{
		/// <summary>
		/// Id of the node clone.
		/// </summary>
		public long NodeId { get; set; }
	}
}
