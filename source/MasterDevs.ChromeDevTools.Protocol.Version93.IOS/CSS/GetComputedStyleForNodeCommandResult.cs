using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.CSS
{
	/// <summary>
	/// Returns the computed style for a DOM node identified by <code>nodeId</code>.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetComputedStyleForNodeCommandResult : ICommandResult
	{
		/// <summary>
		/// Computed style for the specified DOM node.
		/// </summary>
		public CSSComputedStyleProperty[] ComputedStyle { get; set; }
	}
}
