using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// Requests that backend shows the FPS counter
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetShowFPSCounterCommandParams: ICommandParams<SetShowFPSCounterCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowFPSCounter;
		/// <summary>
		/// True for showing the FPS counter
		/// </summary>
		public bool Show { get; set; }
	}
}
