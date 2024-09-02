using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Target
{
	/// <summary>
	/// Returns information about a target.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetTargetInfoCommandParams: ICommandParams<GetTargetInfoCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Target.GetTargetInfo;
		/// <summary>
		/// TargetId
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TargetId { get; set; }
	}
}
