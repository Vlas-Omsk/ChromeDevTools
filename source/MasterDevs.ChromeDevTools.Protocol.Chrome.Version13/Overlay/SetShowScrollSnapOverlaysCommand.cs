using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Overlay
{

	[SupportedBy("Chrome")]
	public class SetShowScrollSnapOverlaysCommand: ICommand<SetShowScrollSnapOverlaysCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowScrollSnapOverlays;
		/// <summary>
		/// An array of node identifiers and descriptors for the highlight appearance.
		/// </summary>
		public ScrollSnapHighlightConfig[] ScrollSnapHighlightConfigs { get; set; }
	}
}
