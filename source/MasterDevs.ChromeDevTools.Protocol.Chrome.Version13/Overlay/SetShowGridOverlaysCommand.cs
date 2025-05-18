using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Overlay
{
	/// <summary>
	/// Highlight multiple elements with the CSS Grid overlay.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetShowGridOverlaysCommand: ICommand<SetShowGridOverlaysCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowGridOverlays;
		/// <summary>
		/// An array of node identifiers and descriptors for the highlight appearance.
		/// </summary>
		public GridNodeHighlightConfig[] GridNodeHighlightConfigs { get; set; }
	}
}
