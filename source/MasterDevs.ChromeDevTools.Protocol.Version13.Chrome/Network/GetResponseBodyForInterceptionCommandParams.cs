using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Version13.Chrome.Network
{
	/// <summary>
	/// Returns content served for the given currently intercepted request.
	/// </summary>

	[SupportedBy("Chrome")]
	public class GetResponseBodyForInterceptionCommandParams: ICommandParams<GetResponseBodyForInterceptionCommandResult>
	{
		public string MethodName { get; } = ProtocolName.Network.GetResponseBodyForInterception;
		/// <summary>
		/// Identifier for the intercepted request to get body for.
		/// </summary>
		public string InterceptionId { get; set; }
	}
}
