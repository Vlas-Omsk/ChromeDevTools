using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	[Command(ProtocolName.Overlay.SetShowFlexOverlays)]
	[SupportedBy("Chrome")]
	public class SetShowFlexOverlaysCommand: ICommandParams<SetShowFlexOverlaysCommandResponse>
	{
		/// <summary>
		/// An array of node identifiers and descriptors for the highlight appearance.
		/// </summary>
		public FlexNodeHighlightConfig[] FlexNodeHighlightConfigs { get; set; }
	}
}
