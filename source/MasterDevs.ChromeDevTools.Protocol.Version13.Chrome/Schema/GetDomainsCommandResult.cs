using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Schema
{
	/// <summary>
	/// Returns supported domains.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetDomainsCommandResult : ICommandResult
	{
		/// <summary>
		/// List of supported domains.
		/// </summary>
		public Domain[] Domains { get; set; }
	}
}
