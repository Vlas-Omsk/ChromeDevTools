using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Returns a dictionary of accessibility properties for the node.
	/// </summary>

	[SupportedBy("IOS")]
	public class GetAccessibilityPropertiesForNodeCommandResult : ICommandResult
	{
		/// <summary>
		/// Dictionary of relevant accessibility properties.
		/// </summary>
		public AccessibilityProperties Properties { get; set; }
	}
}
