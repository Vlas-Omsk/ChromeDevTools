using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Overlay
{
	/// <summary>
	/// Show elements in isolation mode with overlays.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetShowIsolatedElementsCommand: ICommand<SetShowIsolatedElementsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowIsolatedElements;
		/// <summary>
		/// An array of node identifiers and descriptors for the highlight appearance.
		/// </summary>
		public IsolatedElementHighlightConfig[] IsolatedElementHighlightConfigs { get; set; }
	}
}
