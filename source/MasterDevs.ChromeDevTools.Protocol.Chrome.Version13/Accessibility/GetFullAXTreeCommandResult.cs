using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Accessibility
{
	/// <summary>
	/// Fetches the entire accessibility tree for the root Document
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetFullAXTreeCommandResult : ICommandResult
	{
		/// <summary>
		/// Nodes
		/// </summary>
		public AXNode[] Nodes { get; set; }
	}
}
