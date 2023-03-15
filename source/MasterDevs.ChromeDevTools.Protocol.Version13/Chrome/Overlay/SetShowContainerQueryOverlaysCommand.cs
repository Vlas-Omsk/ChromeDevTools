using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	[Command(ProtocolName.Overlay.SetShowContainerQueryOverlays)]
	[SupportedBy("Chrome")]
	public class SetShowContainerQueryOverlaysCommand: IProtocolCommand<SetShowContainerQueryOverlaysCommandResponse>
	{
		/// <summary>
		/// An array of node identifiers and descriptors for the highlight appearance.
		/// </summary>
		public ContainerQueryHighlightConfig[] ContainerQueryHighlightConfigs { get; set; }
	}
}
