using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Overlay
{
	/// <summary>
	/// Highlights owner element of all frames detected to be ads.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetShowAdHighlightsCommand: ICommand<SetShowAdHighlightsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowAdHighlights;
		/// <summary>
		/// True for showing ad highlights
		/// </summary>
		public bool Show { get; set; }
	}
}
