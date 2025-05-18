using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.SystemInfo
{
	/// <summary>
	/// Returns information about the feature state.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetFeatureStateCommand: ICommand<GetFeatureStateCommandResult>
	{
		public string MethodName { get; } = ProtocolName.SystemInfo.GetFeatureState;
		/// <summary>
		/// FeatureState
		/// </summary>
		public string FeatureState { get; set; }
	}
}
