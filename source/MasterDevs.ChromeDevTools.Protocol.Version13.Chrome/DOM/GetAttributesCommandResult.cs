using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Returns attributes for the specified node.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetAttributesCommandResult : ICommandResult
	{
		/// <summary>
		/// An interleaved array of node attribute names and values.
		/// </summary>
		public string[] Attributes { get; set; }
	}
}
