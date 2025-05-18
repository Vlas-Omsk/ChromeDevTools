using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Overlay
{
	/// <summary>
	/// Add a dual screen device hinge
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetShowHingeCommand: ICommand<SetShowHingeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowHinge;
		/// <summary>
		/// hinge data, null means hideHinge
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public HingeConfig HingeConfig { get; set; }
	}
}
