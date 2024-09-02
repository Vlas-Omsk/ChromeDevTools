using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.DOM
{
	/// <summary>
	/// Describes node given its id, does not require domain to be enabled. Does not start tracking any
	/// objects, can be used for automation.
	/// </summary>

	[SupportedBy("Chrome")]
	public class DescribeNodeCommandResult : ICommandResult
	{
		/// <summary>
		/// Node description.
		/// </summary>
		public Node Node { get; set; }
	}
}
