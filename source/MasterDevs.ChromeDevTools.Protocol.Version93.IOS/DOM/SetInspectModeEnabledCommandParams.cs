using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version93.IOS.DOM
{
	/// <summary>
	/// Enters the 'inspect' mode. In this mode, elements that user is hovering over are highlighted. Backend then generates 'inspect' command upon element selection.
	/// </summary>

	[SupportedBy("IOS")]
	public class SetInspectModeEnabledCommandParams: ICommandParams<SetInspectModeEnabledCommandResult>
	{
		public string MethodName { get; } = ProtocolName.DOM.SetInspectModeEnabled;
		/// <summary>
		/// True to enable inspection mode, false to disable it.
		/// </summary>
		public bool Enabled { get; set; }
		/// <summary>
		/// A descriptor for the highlight appearance of hovered-over nodes. May be omitted if <code>enabled == false</code>.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public HighlightConfig HighlightConfig { get; set; }
	}
}
