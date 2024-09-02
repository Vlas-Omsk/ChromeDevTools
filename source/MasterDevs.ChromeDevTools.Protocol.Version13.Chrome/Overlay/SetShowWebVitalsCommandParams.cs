using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Overlay
{
	/// <summary>
	/// Request that backend shows an overlay with web vital metrics.
	/// </summary>

	[SupportedBy("Chrome")]
	public class SetShowWebVitalsCommandParams: ICommandParams<SetShowWebVitalsCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Overlay.SetShowWebVitals;
		/// <summary>
		/// Show
		/// </summary>
		public bool Show { get; set; }
	}
}
