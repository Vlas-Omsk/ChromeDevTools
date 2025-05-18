using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.DOM
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
