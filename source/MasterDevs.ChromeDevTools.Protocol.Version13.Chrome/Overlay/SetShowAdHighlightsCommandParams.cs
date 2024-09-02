using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// Highlights owner element of all frames detected to be ads.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetShowAdHighlightsCommandParams: ICommandParams<SetShowAdHighlightsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowAdHighlights;
		/// <summary>
		/// True for showing ad highlights
		/// </summary>
		public bool Show { get; set; }
	}
}
