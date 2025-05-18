using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.IOS.Version93.CSS
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
