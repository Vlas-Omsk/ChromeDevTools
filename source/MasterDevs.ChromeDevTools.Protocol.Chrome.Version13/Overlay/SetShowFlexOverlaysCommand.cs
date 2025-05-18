using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Overlay
{

	[SupportedBy("Chrome")]
	public class SetShowFlexOverlaysCommand: ICommand<SetShowFlexOverlaysCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowFlexOverlays;
		/// <summary>
		/// An array of node identifiers and descriptors for the highlight appearance.
		/// </summary>
		public FlexNodeHighlightConfig[] FlexNodeHighlightConfigs { get; set; }
	}
}
