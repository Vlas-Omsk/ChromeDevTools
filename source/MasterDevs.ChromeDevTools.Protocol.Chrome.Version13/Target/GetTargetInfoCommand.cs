using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Target
{
	/// <summary>
	/// Returns information about a target.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetTargetInfoCommand: ICommand<GetTargetInfoCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Target.GetTargetInfo;
		/// <summary>
		/// TargetId
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TargetId { get; set; }
	}
}
