using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// Add a dual screen device hinge
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetShowHingeCommandParams: ICommandParams<SetShowHingeCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowHinge;
		/// <summary>
		/// hinge data, null means hideHinge
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public HingeConfig HingeConfig { get; set; }
	}
}
