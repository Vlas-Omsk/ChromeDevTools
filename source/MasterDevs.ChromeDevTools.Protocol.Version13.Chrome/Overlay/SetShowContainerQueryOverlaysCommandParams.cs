using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{

	[SupportedBy("Chrome")]
	public class SetShowContainerQueryOverlaysCommandParams: ICommandParams<SetShowContainerQueryOverlaysCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowContainerQueryOverlays;
		/// <summary>
		/// An array of node identifiers and descriptors for the highlight appearance.
		/// </summary>
		public ContainerQueryHighlightConfig[] ContainerQueryHighlightConfigs { get; set; }
	}
}
