using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Returns boxes for the given node.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetBoxModelCommandResult : ICommandResult
	{
		/// <summary>
		/// Box model for the node.
		/// </summary>
		public BoxModel Model { get; set; }
	}
}
