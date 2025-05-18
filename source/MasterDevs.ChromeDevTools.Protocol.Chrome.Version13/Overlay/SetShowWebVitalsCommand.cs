using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Overlay
{
	/// <summary>
	/// Request that backend shows an overlay with web vital metrics.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetShowWebVitalsCommand: ICommand<SetShowWebVitalsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowWebVitals;
		/// <summary>
		/// Show
		/// </summary>
		public bool Show { get; set; }
	}
}
