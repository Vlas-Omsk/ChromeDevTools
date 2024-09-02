using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.CSS
{
	/// <summary>
	/// Returns the computed style for a DOM node identified by `nodeId`.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetComputedStyleForNodeCommandResult : ICommandResult
	{
		/// <summary>
		/// Computed style for the specified DOM node.
		/// </summary>
		public CSSComputedStyleProperty[] ComputedStyle { get; set; }
	}
}
