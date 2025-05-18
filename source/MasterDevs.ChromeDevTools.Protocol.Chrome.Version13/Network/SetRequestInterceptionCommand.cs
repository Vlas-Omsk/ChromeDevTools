using MasterDevs.ChromeDevTools.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Version13.Network
{
	/// <summary>
	/// Sets the requests to intercept that match the provided patterns and optionally resource types.
	/// Deprecated, please use Fetch.enable instead.
	/// </summary>
	[Obsolete]

	[SupportedBy("Chrome")]
	public class SetRequestInterceptionCommand: ICommand<SetRequestInterceptionCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.SetRequestInterception;
		/// <summary>
		/// Requests matching any of these patterns will be forwarded and wait for the corresponding
		/// continueInterceptedRequest call.
		/// </summary>
		public RequestPattern[] Patterns { get; set; }
	}
}
