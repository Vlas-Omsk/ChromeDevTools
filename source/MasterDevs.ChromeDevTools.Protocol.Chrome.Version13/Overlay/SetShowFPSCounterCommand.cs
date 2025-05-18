using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Overlay
{
	/// <summary>
	/// Requests that backend shows the FPS counter
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetShowFPSCounterCommand: ICommand<SetShowFPSCounterCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowFPSCounter;
		/// <summary>
		/// True for showing the FPS counter
		/// </summary>
		public bool Show { get; set; }
	}
}
