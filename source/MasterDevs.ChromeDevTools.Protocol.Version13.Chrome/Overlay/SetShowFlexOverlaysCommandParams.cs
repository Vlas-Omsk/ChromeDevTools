using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{

	[SupportedBy("Chrome")]
	public class SetShowFlexOverlaysCommandParams: ICommandParams<SetShowFlexOverlaysCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowFlexOverlays;
		/// <summary>
		/// An array of node identifiers and descriptors for the highlight appearance.
		/// </summary>
		public FlexNodeHighlightConfig[] FlexNodeHighlightConfigs { get; set; }
	}
}
