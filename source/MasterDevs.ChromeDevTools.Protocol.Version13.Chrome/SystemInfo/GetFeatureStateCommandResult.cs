using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.SystemInfo
{
	/// <summary>
	/// Returns information about the feature state.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetFeatureStateCommandResult : ICommandResult
	{
		/// <summary>
		/// FeatureEnabled
		/// </summary>
		public bool FeatureEnabled { get; set; }
	}
}
