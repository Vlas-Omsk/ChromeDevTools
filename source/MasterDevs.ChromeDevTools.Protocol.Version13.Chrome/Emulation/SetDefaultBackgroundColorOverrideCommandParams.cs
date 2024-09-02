using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Emulation
{
	/// <summary>
	/// Sets or clears an override of the default background color of the frame. This override is used
	/// if the content does not specify one.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetDefaultBackgroundColorOverrideCommandParams: ICommandParams<SetDefaultBackgroundColorOverrideCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Emulation.SetDefaultBackgroundColorOverride;
		/// <summary>
		/// RGBA of the default background color. If not specified, any existing override will be
		/// cleared.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA Color { get; set; }
	}
}
