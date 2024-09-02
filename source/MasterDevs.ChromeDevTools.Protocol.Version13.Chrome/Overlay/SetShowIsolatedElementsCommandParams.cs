using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// Show elements in isolation mode with overlays.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetShowIsolatedElementsCommandParams: ICommandParams<SetShowIsolatedElementsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowIsolatedElements;
		/// <summary>
		/// An array of node identifiers and descriptors for the highlight appearance.
		/// </summary>
		public IsolatedElementHighlightConfig[] IsolatedElementHighlightConfigs { get; set; }
	}
}
