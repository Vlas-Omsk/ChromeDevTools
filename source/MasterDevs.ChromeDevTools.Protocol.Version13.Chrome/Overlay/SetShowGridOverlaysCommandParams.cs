using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// Highlight multiple elements with the CSS Grid overlay.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetShowGridOverlaysCommandParams: ICommandParams<SetShowGridOverlaysCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowGridOverlays;
		/// <summary>
		/// An array of node identifiers and descriptors for the highlight appearance.
		/// </summary>
		public GridNodeHighlightConfig[] GridNodeHighlightConfigs { get; set; }
	}
}
