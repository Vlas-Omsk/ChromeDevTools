using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Enters the 'inspect' mode. In this mode, elements that user is hovering over are highlighted.
	/// Backend then generates 'inspectNodeRequested' event upon element selection.
	/// </summary>
	[Command(ProtocolName.Overlay.SetInspectMode)]
	[SupportedBy("Chrome")]
	public class SetInspectModeCommand: ICommandParams<SetInspectModeCommandResponse>
	{
		/// <summary>
		/// Set an inspection mode.
		/// </summary>
		public string Mode { get; set; }
		/// <summary>
		/// A descriptor for the highlight appearance of hovered-over nodes. May be omitted if `enabled
		/// == false`.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public HighlightConfig HighlightConfig { get; set; }
	}
}
