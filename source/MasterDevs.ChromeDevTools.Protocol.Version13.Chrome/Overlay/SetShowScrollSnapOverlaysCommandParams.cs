using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{

	[SupportedBy("Chrome")]
	public class SetShowScrollSnapOverlaysCommandParams: ICommandParams<SetShowScrollSnapOverlaysCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowScrollSnapOverlays;
		/// <summary>
		/// An array of node identifiers and descriptors for the highlight appearance.
		/// </summary>
		public ScrollSnapHighlightConfig[] ScrollSnapHighlightConfigs { get; set; }
	}
}
