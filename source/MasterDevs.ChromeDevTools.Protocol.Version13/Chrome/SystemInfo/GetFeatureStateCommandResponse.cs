using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.SystemInfo
{
	/// <summary>
	/// Returns information about the feature state.
	/// </summary>
	[CommandResponse(ProtocolName.SystemInfo.GetFeatureState)]
	[SupportedBy("Chrome")]
	public class GetFeatureStateCommandResponse
	{
		/// <summary>
		/// FeatureEnabled
		/// </summary>
		public bool FeatureEnabled { get; set; }
	}
}
