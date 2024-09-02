using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Modifies the expression of a container query.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetContainerQueryTextCommandResult : ICommandResult
	{
		/// <summary>
		/// The resulting CSS container query rule after modification.
		/// </summary>
		public CSSContainerQuery ContainerQuery { get; set; }
	}
}
