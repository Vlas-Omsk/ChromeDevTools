using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Sets the requests to intercept that match the provided patterns and optionally resource types.
	/// Deprecated, please use Fetch.enable instead.
	/// </summary>
	[Obsolete]

	[SupportedBy("Chrome")]
	public class SetRequestInterceptionCommandParams: ICommandParams<SetRequestInterceptionCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.SetRequestInterception;
		/// <summary>
		/// Requests matching any of these patterns will be forwarded and wait for the corresponding
		/// continueInterceptedRequest call.
		/// </summary>
		public RequestPattern[] Patterns { get; set; }
	}
}
