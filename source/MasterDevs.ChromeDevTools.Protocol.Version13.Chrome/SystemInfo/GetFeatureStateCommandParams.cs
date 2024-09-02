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
	public class GetFeatureStateCommandParams: ICommandParams<GetFeatureStateCommandResult>
	{
		public string MethodName { get; } = ProtocolName.SystemInfo.GetFeatureState;
		/// <summary>
		/// FeatureState
		/// </summary>
		public string FeatureState { get; set; }
	}
}
